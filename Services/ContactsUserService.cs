using System.Collections.Generic;
using System.Linq;
using Contacts.Lib;
using Contacts.Models;

namespace Contacts.Services;

public class ContactsUserService
{
    public IEnumerable<ContactsUser> GetUsers()
    {

        var users = new List<ContactsUser>();
        for (var i = 0; i < 10; i++)
        {
            var user = new ContactsUser
            {
                Name = $"联系人-{i}",
                Mobile = $"186-0000-888{i}",
                Address = "地址地址地址地址地址地址地址地址地址地址地址地址地址地址地址地址"
            };
            users.Add(user);
        }

        return users;

    }




}