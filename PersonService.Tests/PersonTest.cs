using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonService.Tests
{
    [TestClass]
    public class PersonTest
    {
        private Person person;

        [TestMethod]
        public void ShouldCreateEmptyObject()
        {
            person = new Person();

            Assert.AreEqual("Person[firstname=, lastname=]", person.ToString());
        }

        [TestMethod]
        public void ShouldSetFirstName()
        {
            person = new Person();
            person.Firstname = "Test";

            Assert.AreEqual("Test", person.Firstname);
        }

        [TestMethod]
        public void ShouldSetLastName()
        {
            person = new Person();
            person.Lastname = "Test";

            Assert.AreEqual("Test", person.Lastname);
        }

        [TestMethod]
        public void ShouldSetAllAttributes()
        {
            person = new Person();
            person.Firstname = "Test";
            person.Lastname = "Test";

            Assert.AreEqual("Person[firstname=Test, lastname=Test]", person.ToString());
        }
    }
}
