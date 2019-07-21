using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeExcercise
{
    // *** Classes and buisness logic should not be in a test project
    // *** Field use rather than properties on classes please
    // *** https://stackoverflow.com/questions/3069901/properties-vs-fields-need-help-grasping-the-uses-of-properties-over-fields
    // *** Please see the solution I have provided
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void Test1()
        {

            // *** Missing Cost Per Visit From The Report 
            // *** Please see the suggested data structure 
            var pets = new List<Pet>()
            {
                new Dog() { Firstname = "Jim", Lastname = "Rogers", numberofVisits = 5, joinedPractice = DateTime.Now},
                new Dog() { Firstname = "Tony", Lastname = "Smith", numberofVisits = 10, joinedPractice = new DateTime(1985, 7, 13)},
                new Cat() { Firstname = "Steve", Lastname = "Roberts", numberofVisits = 20, joinedPractice = new DateTime(2002, 5, 6), numberOfLives = 9 }
            };

            new Pet().printReport(pets, "PetsReport.csv");
            var outPets = File.ReadAllLines("PetsReport.csv");

            Assert.AreEqual(4, outPets.Count());
        }
    }

    public class Pet : Owner
    {
        public int numberofVisits;
        public DateTime joinedPractice;

        // NOTE: This method prints a pets reports in csv format.
        // **** This breaks Single Object of responsibility methodology
        // **** Report generation needs in a seperate class
        public void printReport(IEnumerable<Pet> pets, string filename)
        {
            List<string> entries = new List<string>();
            entries.Add("Owners name,Date Joined Practice,Number Of Visits,Number of Lives");
            foreach (var p in pets)
            {
                // ****  Ineffiecient way of concatenating a string use stringbuilder or string.format instead
                var entry = string.Join(" ", p.Firstname, p.Lastname) + p.joinedPractice + "," + p.numberofVisits;

                // **** This type of conditional code will become complex as more Animals are included
                // **** We could add quirky items like this as a 'Character' property of a new Animal class.
                if (p is Cat)
                {
                    var cat = p as Cat;
                    entry += "," + cat.numberOfLives;
                }

                entries.Add(entry);
            }
            File.WriteAllLines(filename, entries.ToArray());
        }
    }

    // *** Appreciate your use of inheritance as an OO construct
    // *** However As the system grows do we really want a class for each animal? Thats going to add complex conditional
    // *** code on the report
    // *** We could continue to use inheritance for the Pet : Owner relationship. 
    public class Dog : Pet
    {
        public double CostPerVisit;
    }

    public class Cat : Pet
    {
        // *** Casing should be upper... Helps distinguish between properties of a class and
        // *** for example local variables that may have a similar name, these should be lowwercase
        // *** Also int? Nullable int. Is that there for a reason? Should be avoided unless very specific 
        // *** requirement
        public int? numberOfLives;

        // *** Double is for maths use decimal(6,2)
        public double CostPerVisit;
    }

    public class Owner
    {
        public string Firstname;

        public string Lastname;
    }

}
