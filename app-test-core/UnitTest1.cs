using System;
using app_core;
using Xunit;

namespace app_test_core
{
    public class ExtendContacto : Contacto
    {
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public string Comentario { get; set; }
    }
    public class UnitTest1
    {
        private ExtendContacto newContact;

        [Fact]
        public void Test1()
        {
            newContact = new ExtendContacto();
            Assert.IsType<ExtendContacto>(newContact);

        }

        [Fact]
        public void Test2()
        {
            newContact = new ExtendContacto();
            newContact.Edad = 56;

            Assert.IsType<int>(newContact.Edad);
        }
    }
}
