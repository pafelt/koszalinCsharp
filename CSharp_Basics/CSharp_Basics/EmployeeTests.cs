using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    class EmployeeTests
    {
        [Test]
        public void Employee_Creation_FieldProperlyField()
        {
          var employee =  new Employee("Emka", 666, "Koszalin");
          var employee1 = new Employee("Lama", 999, "Wroclaw");
          var employee2 = new Employee("Bartosz", 969, "Szczecin");



            Assert.Multiple(() =>
                {
                    Assert.That(employee.BadgeID, Is.EqualTo(666));
                    Assert.That(employee.LocationToString, Is.EqualTo("Koszalin"));
                    Assert.That(employee.Name, Is.EqualTo("Emka"));

                    Assert.That(employee1.BadgeID, Is.EqualTo(999));
                    Assert.That(employee1.LocationToString, Is.EqualTo("Wroclaw"));
                    Assert.That(employee1.Name, Is.EqualTo("Lama"));

                    Assert.That(employee2.BadgeID, Is.EqualTo(969));
                    Assert.That(employee2.LocationToString, Is.EqualTo("Szczecin"));
                    Assert.That(employee2.Name, Is.EqualTo("Bartosz"));
                });
        }

        [Test]
        public void EmployeeIT_Creation_FieldProperlyField()
        {
            var employee3 = new ItEmployee("Elka", 123, "Wroclaw", "CSharp");

            Assert.That(employee3.BadgeID, Is.EqualTo(123));
            Assert.That(employee3.LocationToString, Is.EqualTo("Wroclaw"));
            Assert.That(employee3.Name, Is.EqualTo("Elka"));
            Assert.That(employee3.ProgrammingToString, Is.EqualTo("CSharp"));
        }

        [Test]
        public void EmployeeIT_CreationUsinEnum_FieldProperlyField()
        {
            var employee3 = new ItEmployee("Elka", 123, "Wroclaw", "CSharp");

            Assert.That(employee3.BadgeID, Is.EqualTo(123));
            Assert.That(employee3.LocationToString, Is.EqualTo("Wroclaw"));
            Assert.That(employee3.Name, Is.EqualTo("Elka"));
            Assert.That(employee3.ProgrammingToString, Is.EqualTo("CSharp"));
        }

        [TestCase(Locations.Szczecin,true )]
        [TestCase(Locations.Koszalin, true)]
        [TestCase(Locations.Wroclaw, false)]
        [TestCase(Locations.ZielonaGora, false)]
        [TestCase(Locations.Krakow, false)]
        public void LocationAboveWarsaw(Locations locations, bool result)
        {
            var employee = new Employee("Opos", 321, locations);

            Assert.That(employee.IsNorthWarsaw, Is.EqualTo(result));
           // throw new ArgumentOutOfRangeException();

        }
        //północ
        /*id 
        1-5 - 5 cyfr
        południe
        6-9 - 5 cyfr

        throw new ArgumentOutOfRangeException();*/
        [Test]
        public void Employe_IDIsOutRange_ThrowArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new ItEmployee("Em", 666, Locations.Koszalin, ProgrammingLanguages.CSharp)
                );
        }
        [TestCase(Locations.Koszalin,11111)]
        [TestCase(Locations.Szczecin,22222)]

        [TestCase(Locations.Koszalin,11111)]
        [TestCase(Locations.ZielonaGora,66666)]
        public void Employe_IDisInWrongRange_ThrowsArgrumentOutOfRange(Locations loc, int badge)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Employee("Emka", badge, loc)
            );
        }
    }
}
