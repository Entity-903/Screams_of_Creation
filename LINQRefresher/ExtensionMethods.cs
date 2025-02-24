using System;
using System.Collections.Generic;
using System.Linq;
using LINQRefresher_v3.Enums;
using LINQRefresher_v3.Models;

// How do we test these methods? Likely unit tests, but it has been a while since I have used those. A refresher will be necessary
// Is there a site that lists every method LINQ uses

// In the case of dictionaries
// if key does not already exist in the dictionary, create new key
// else add value to the collection the key points to

namespace LINQRefresher_v3.ExtensionMethods
{
    public static class ExtensionMethods
    {
        /*
         * Using the method names and comments below, implement each extension method.
         * You will receive a grade based on how your implementation functions
         * during a series of automated tests. You may implement the methods
         * using any combination of comprehension, extension, or desugarized
         * syntax.
         */

        /// <summary>
        /// Returns a collection of students based on the indicated Gender
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <param name="gender">The Gender value requested</param>
        /// <returns>The collection of Students with the same gender as the parameter</returns>
        public static IEnumerable<Student> GetStudentsByGender(this IEnumerable<Student> students, Genders gender)
        {
            //Console.WriteLine(students.Where(x=>x.Gender == gender));
            return (students.Where(x => x.Gender == gender));
        }

        /// <summary>
        /// Returns a collection of students where the ages fall between the inclusive min and max values
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <param name="minYearsOld">Inclusive minimum age</param>
        /// <param name="maxYearsOld">Inclusive maximum age</param>
        /// <returns>The collection of Students that match the criteria</returns>
        public static IEnumerable<Student> GetStudentsByAgeRange(this IEnumerable<Student> students, int minYearsOld, int maxYearsOld)
        {
            var temp = students.Where(x => x.Age >= minYearsOld);
			return (temp.Where(x => x.Age <= maxYearsOld));
        }

        /// <summary>
        /// Gets the Students with a GPA below 2.0
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <returns>The collection of students not currently passing</returns>
        public static IEnumerable<Student> GetTheFailingStudents(this IEnumerable<Student> students)
        {
            return (students.Where(x => x.GPA < 2.0));
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reports the number of students in each ClassLevel designation
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <returns>A Dictionary where the key is the ClassLevel and the value is the number of students in that level</returns>
        public static Dictionary<ClassLevel, int> StudentsPerClassLevel(this IEnumerable<Student> students)
        {
			throw new NotImplementedException();
			//return students.Select(x => x.Level).Cast<Dictionary<string, int>>().Where()
		}

        /// <summary>
        /// Determines which MaritalStatus has the highest average GPA
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <returns>The MaritalStatus value with the highest average GPA</returns>
        public static MaritalStatus MaritalStatusWithHighestAverageGPA(this IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a collection containing the top students in each ClassLevel designation.
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <param name="count">The number of top students per ClassLevel being requested</param>
        /// <returns>The collection of the top students</returns>
        public static IEnumerable<Student> TopOfTheClass(this IEnumerable<Student> students, int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines which students are still not legal adults. NOTE: this query should work every year that it is run.
        /// </summary>
        /// <param name="students">The original collection of students</param>
        /// <returns>The collection of students that are under the age of 18</returns>
        public static IEnumerable<Student> UnderageStudents(this IEnumerable<Student> students)
        {
            return students.Where(x => x.Age < 18);
        }

        /// <summary>
        /// Takes in a collection of Person objects and returns a collection of those that are Student objects
        /// </summary>
        /// <param name="people">The original collection of Person objects</param>
        /// <returns>The collection of Person objects that are actually Students</returns>
        public static IEnumerable<Student> FindTheStudents(this IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines the percentage of Person objects that are Students
        /// </summary>
        /// <param name="people">The original collection of people</param>
        /// <returns>The percentage of Person objects that are also Students expressed as a float less than or equal to 1.0</returns>
        public static float CurrentPercentageOfPeopleInSchool(this IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Analyses a collection of Person objects and reports how many people are born under each sign of the zodiac
        /// </summary>
        /// <param name="people">The original collection or Person objects</param>
        /// <returns>A Dictionary where the key is the sign and the value is the number of people born under it</returns>
        public static Dictionary<ZodiacSign, int> NumberOfPeopleByBirthSign(this IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		//HELPER METHOD - You do not need to use LINQ for this.
		/// <summary>
		/// Derives the Zodiac sign for an instance of Person based on its Birthdate property
		/// </summary>
		/// <param name="p">The target Person object whose Zodiac sign will be derived</param>
		/// <returns>The ZodiacSign enum value for the target Person object</returns>
		public static ZodiacSign BirthSign(this Person p)
        {
			//AGE should be get only; use Birthdate to derive the value
            if (p.Birthdate >= DateTime.Parse("01/21/2011") && p.Birthdate <= DateTime.Parse("02/19/2011")) return ZodiacSign.Aquarius;
            if (p.Birthdate >= DateTime.Parse("02/20/2011") && p.Birthdate <= DateTime.Parse("03/20/2011")) return ZodiacSign.Pisces;
            if (p.Birthdate >= DateTime.Parse("03/21/2011") && p.Birthdate <= DateTime.Parse("04/20/2011")) return ZodiacSign.Aries;
            if (p.Birthdate >= DateTime.Parse("04/21/2011") && p.Birthdate <= DateTime.Parse("05/21/2011")) return ZodiacSign.Taurus;
            if (p.Birthdate >= DateTime.Parse("05/22/2011") && p.Birthdate <= DateTime.Parse("06/21/2011")) return ZodiacSign.Gemini;
            if (p.Birthdate >= DateTime.Parse("06/22/2011") && p.Birthdate <= DateTime.Parse("07/22/2011")) return ZodiacSign.Cancer;
            if (p.Birthdate >= DateTime.Parse("07/23/2011") && p.Birthdate <= DateTime.Parse("08/22/2011")) return ZodiacSign.Leo;
            if (p.Birthdate >= DateTime.Parse("08/23/2011") && p.Birthdate <= DateTime.Parse("09/23/2011")) return ZodiacSign.Virgo;
            if (p.Birthdate >= DateTime.Parse("09/24/2011") && p.Birthdate <= DateTime.Parse("10/23/2011")) return ZodiacSign.Libra;
            if (p.Birthdate >= DateTime.Parse("10/24/2011") && p.Birthdate <= DateTime.Parse("11/22/2011")) return ZodiacSign.Scorpio;
            if (p.Birthdate >= DateTime.Parse("11/23/2011") && p.Birthdate <= DateTime.Parse("12/21/2011")) return ZodiacSign.Saggitarius;
            //if (p.Birthdate >= DateTime.Parse("12/22/2011") && p.Birthdate <= DateTime.Parse("01/20/2011")) return ZodiacSign.Capricorn;
            else
            {
				return ZodiacSign.Capricorn;
			}
        }
    }
}
