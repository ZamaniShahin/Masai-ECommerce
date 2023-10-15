using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccountRepository _accountRepository;

        public AccountApplication(IAccountRepository accountRepository, IPasswordHasher passwordHasher, IFileUploader fileUploader)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateAccount command)
        {
            var operation = new OperationResult();

            if (_accountRepository.Exists(x => x.UserName == command.UserName || command.Mobile == x.Mobile))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            var password = _passwordHasher.Hash(command.Password);
            var path = $"ProfilePhotos";
            var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);
            var account = new Account(command.FullName, command.UserName
                , password, command.Mobile,command.Email,command.RoleId,picturePath);
            _accountRepository.Create(account);
            _accountRepository.SaveChanges();

            return operation.Succeeded();
        }

        public OperationResult Edit(EditAccount command)
        {
            var operation = new OperationResult();

            var account = _accountRepository.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_accountRepository.Exists(x => x.UserName == command.UserName && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            var path = $"ProfilePhotos";
            var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);
            account.Edit(command.FullName, command.UserName,
                command.Mobile, command.Email, command.RoleId, picturePath);
            _accountRepository.SaveChanges();

            return operation.Succeeded();
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (command.Password != command.RePassword)
                return operation.Failed(ApplicationMessages.PasswordNotMatched);
            account.ChangePassword(command.Password);

            var password = _passwordHasher.Hash(command.Password);
            account.ChangePassword(password);
            _accountRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditAccount GetDetails(long id)
        {
            return _accountRepository.GetDetails(id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            return _accountRepository.Search(searchModel);
        }

        public OperationResult Login(Login command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.GetBy(command.UserName);
            if (account == null)
                return operation.Failed(ApplicationMessages.WrongUserPass);

            (bool verified,bool needUpgrade) result = _passwordHasher.Check(account.Password,command.Password);
            if (!result.verified)
                return operation.Failed(ApplicationMessages.WrongUserPass);
            return operation.Succeeded();
        }
    }
}