using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //created an array of objects with 5 slots
            var arrayOfObjects = new object[5];

            //created new list of strings
            var studentsWithBlackHair = new List<string> { "Nathan", "Austin", "Marty McFly" }; //collection initialization

            //dictionary. The <> is for 'generic'. Takes a key-value pair.
            var studentsByHairColor = new Dictionary<string, List<string>>
            {
                {"Black", studentsWithBlackHair}
            };

            studentsByHairColor.Add("Bald", new List<string> { "Martin" });

            var theBlackHairedStudents = studentsByHairColor["Black"];

            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same.");
            }

            studentsByHairColor["Black"].Add("new person");

            foreach (var (hairColor, students) in studentsByHairColor)
            {
                Console.WriteLine($"The following students have {hairColor.ToLower()} hair.");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            Console.ReadKey();

        }
    }
}
