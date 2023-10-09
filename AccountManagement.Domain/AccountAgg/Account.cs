﻿using _0_Framework.Domain;

namespace AccountManagement.Domain.AccountAgg;

public class Account : EntityBase
{
    public string FullName { get; private set; }
    public string UserName { get; private set; }
    public string Password { get; private set; }
    public string Mobile { get; private set; }
    public string Email { get; private set; }
    public long RoleId { get; private set; }
    public string ProfilePhoto { get; private set; }

    public Account(string fullName, string userName, string password, string mobile, string email, long roleId, string profilePhoto)
    {
        FullName = fullName;
        UserName = userName;
        Password = password;
        Mobile = mobile;
        Email = email;
        RoleId = roleId;
        ProfilePhoto = profilePhoto;
    }
    public void Edit(string fullName, string userName, string mobile, string email, long roleId, string profilePhoto)
    {
        FullName = fullName;
        UserName = userName;
        Mobile = mobile;
        Email = email;
        RoleId = roleId;
        if (!string.IsNullOrWhiteSpace(profilePhoto))
            ProfilePhoto = profilePhoto;
    }

    public void ChangePassword(string password)
    {
        Password = password;
    }
}