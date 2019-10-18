using System;
using app_web.Models;
using Xunit;

namespace app_test_web
{
    public class UnitTest1
    {
        private ContactoViewModel newContact;

        [Fact]
        public void Test1()
        {
            newContact = new ContactoViewModel();
            Assert.IsType<ContactoViewModel>(newContact);

        }
        
    }
}
