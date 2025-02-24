using System.Net.Cache;
using LINQRefresher_v3.Enums;
using LINQRefresher_v3.ExtensionMethods;
using LINQRefresher_v3.Models;

namespace UnitTests
{
	public class LINQRefresherUnitTests
	{
		// AAA Approach
		// Arrange - Values to test and compare
		// Act - Running the code we are testing
		// Assert - Compare expectedValue to actualValue to see if they are the same

		public Student[] students = new Student[]
			{
			new Student("Emma Watson",     LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("04/15/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   0, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
			new Student("David Beckham",   LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("05/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  1, 1.7f, LINQRefresher_v3.Enums.ClassLevel.Sophomore),
			new Student("Oprah Winfrey",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("01/29/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   2, 3.2f, LINQRefresher_v3.Enums.ClassLevel.Junior),
			new Student("Keanu Reeves",    LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("09/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   3, 3.1f, LINQRefresher_v3.Enums.ClassLevel.Senior),
			new Student("Ariana Grande",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("06/26/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 4, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Sophomore),
			new Student("Chris Hemsworth", LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("08/11/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  5, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
			new Student("Beyoncé Knowles", LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("09/04/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  6, 3.4f, LINQRefresher_v3.Enums.ClassLevel.Junior),
			new Student("Tom Hanks",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("07/09/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  7, 3.9f, LINQRefresher_v3.Enums.ClassLevel.Senior),
			new Student("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  8, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
			new Student("Brad Pitt",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("12/18/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 9, 1.9f, LINQRefresher_v3.Enums.ClassLevel.Sophomore)
			};

		public Person[] people = new Person[] 
		{
			new Person("Emma Watson",     LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("04/15/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single),
			new Person("David Beckham",   LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("05/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married),
			new Person("Oprah Winfrey",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("01/29/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single),
			new Person("Keanu Reeves",    LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("09/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single),
			new Person("Ariana Grande",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("06/26/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced),
			new Person("Chris Hemsworth", LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("08/11/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed),
			new Person("Beyoncé Knowles", LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("09/04/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married),
			new Person("Tom Hanks",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("07/09/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married),
			new Person("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed),
			new Person("Brad Pitt",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("12/18/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced)
		};

		[Fact]
		public void GetStudentsByGenderHappyPath()
		{
			Student[] _students = students;
			Genders gender = Genders.Female;
			Student[] expected = new Student[]
				{ 
					new Student("Emma Watson",     LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("04/15/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   0, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
					new Student("Oprah Winfrey",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("01/29/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   2, 3.2f, LINQRefresher_v3.Enums.ClassLevel.Junior),
					new Student("Ariana Grande",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("06/26/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 4, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Sophomore),
					new Student("Beyoncé Knowles", LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("09/04/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  6, 3.4f, LINQRefresher_v3.Enums.ClassLevel.Junior),
					new Student("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  8, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
				};
			Student[] actual = ExtensionMethods.GetStudentsByGender(_students, gender).ToArray();
			// We check to see if both collections are of equal length. Immediately fail if not.
			// Use Zip to compare the individual elements of each Student. Fail if not equal.
			// All checks to ensure that every comparison in Zip is true
			Assert.True(expected.Length == actual.Length &&
				expected.Zip(actual, (e, a) => (e.Name == a.Name) &&
											   (e.Gender == a.Gender) &&
											   (e.Birthdate == a.Birthdate) &&
											   (e.Relationship == a.Relationship) &&
											   (e.StudentId == a.StudentId) &&
											   (e.GPA == a.GPA) &&
											   (e.Level == a.Level)
				).All(x => x));
		}

		[Fact]
		public void GetTheFailingStudentsHappyPath()
		{
			Student[] _students = students;
			float minimumRequirement = 2.0f;
			Student[] expected = new Student[]
				{
					new Student("David Beckham",   LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("05/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  1, 1.7f, LINQRefresher_v3.Enums.ClassLevel.Sophomore),
					new Student("Chris Hemsworth", LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("08/11/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  5, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
					new Student("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  8, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
					new Student("Brad Pitt",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("12/18/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 9, 1.9f, LINQRefresher_v3.Enums.ClassLevel.Sophomore)


				};
			Student[] actual = ExtensionMethods.GetTheFailingStudents(_students).ToArray();
			// We check to see if both collections are of equal length. Immediately fail if not.
			// Use Zip to compare the individual elements of each Student. Fail if not equal.
			// All checks to ensure that every comparison in Zip is true
			Assert.True(expected.Length == actual.Length &&
				expected.Zip(actual, (e, a) => (e.Name == a.Name) &&
											   (e.Gender == a.Gender) &&
											   (e.Birthdate == a.Birthdate) &&
											   (e.Relationship == a.Relationship) &&
											   (e.StudentId == a.StudentId) &&
											   (e.GPA == a.GPA) &&
											   (e.Level == a.Level)
				).All(x => x));
		}
	}
}