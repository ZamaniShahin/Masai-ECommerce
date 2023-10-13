using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.RoleAgg;
using System.Collections.Generic;
using System.Linq;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class RoleRepository : RepositoryBase<long, Role>, IRoleRepository
    {
        private readonly AccountContext _accountContext;

        public RoleRepository(AccountContext accountContext) : base(accountContext)
        {
            _accountContext = accountContext;
        }

        public EditRole GetDetails(long id)
        {
            var role = _accountContext.Roles.Select(x => new EditRole
            {
                Id = x.Id,
                Name = x.Name
            }).FirstOrDefault(x => x.Id == id);
            return role;
        }

        public List<RoleViewModel> List()
        {
            return _accountContext.Roles.Select(x => new RoleViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}