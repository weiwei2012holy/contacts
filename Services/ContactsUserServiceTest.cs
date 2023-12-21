using Contacts.Lib;
using Contacts.Services;
using NUnit.Framework;

namespace Contacts.Services;

[TestFixture]
[TestOf(typeof(ContactsUserService))]
public class ContactsUserServiceTest
{

    [Test]
    public void TestGetUser()
    {
        var service = new ContactsUserService();

        var users = service.GetUsers();
        foreach (var user in users)
        {
            Helper.Dump(user.Name,user.Mobile);

        }
    }
    
    
    [Test]
    public void Test2()
    {
        
        Helper.Dump("test3");
    }

    
    
}