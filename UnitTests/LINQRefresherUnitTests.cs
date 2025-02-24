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
			new Student("David Beckham",   LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("05/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  1, 3.7f, LINQRefresher_v3.Enums.ClassLevel.Sophomore),
			new Student("Oprah Winfrey",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("01/29/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   2, 3.2f, LINQRefresher_v3.Enums.ClassLevel.Junior),
			new Student("Keanu Reeves",    LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("09/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   3, 3.1f, LINQRefresher_v3.Enums.ClassLevel.Senior),
			new Student("Ariana Grande",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("06/26/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 4, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Sophomore),
			new Student("Chris Hemsworth", LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("08/11/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  5, 3.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
			new Student("Beyoncé Knowles", LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("09/04/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  6, 3.4f, LINQRefresher_v3.Enums.ClassLevel.Junior),
			new Student("Tom Hanks",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("07/09/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  7, 3.9f, LINQRefresher_v3.Enums.ClassLevel.Senior),
			new Student("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  8, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman),
			new Student("Brad Pitt",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("12/18/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 9, 2.0f, LINQRefresher_v3.Enums.ClassLevel.Sophomore)
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

		//public void setStudents()
		//{
		//	students[0] = new Student("Emma Watson",     LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("04/15/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   0, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Freshman);
		//	students[1] = new Student("David Beckham",   LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("05/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  1, 3.7f, LINQRefresher_v3.Enums.ClassLevel.Sophomore);
		//	students[2] = new Student("Oprah Winfrey",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("01/29/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   2, 3.2f, LINQRefresher_v3.Enums.ClassLevel.Junior);
		//	students[3] = new Student("Keanu Reeves",    LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("09/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single,   3, 3.1f, LINQRefresher_v3.Enums.ClassLevel.Senior);
		//	students[4] = new Student("Ariana Grande",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("06/26/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 4, 4.0f, LINQRefresher_v3.Enums.ClassLevel.Sophomore);
		//	students[5] = new Student("Chris Hemsworth", LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("08/11/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  5, 3.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman);
		//	students[6] = new Student("Beyoncé Knowles", LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("09/04/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  6, 3.4f, LINQRefresher_v3.Enums.ClassLevel.Junior);
		//	students[7] = new Student("Tom Hanks",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("07/09/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married,  7, 3.9f, LINQRefresher_v3.Enums.ClassLevel.Senior);
		//	students[8] = new Student("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed,  8, 1.5f, LINQRefresher_v3.Enums.ClassLevel.Freshman);
		//	students[9] = new Student("Brad Pitt",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("12/18/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced, 9, 2.0f, LINQRefresher_v3.Enums.ClassLevel.Sophomore);
		//}
		//
		//// complete this database, then update Students with People
		//public void setPeople()
		//{
		//	people[0] = new Person("Emma Watson",     LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("04/15/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single);
		//	people[1] = new Person("David Beckham",   LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("05/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married);
		//	people[2] = new Person("Oprah Winfrey",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("01/29/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single);
		//	people[3] = new Person("Keanu Reeves",    LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("09/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Single);
		//	people[4] = new Person("Ariana Grande",   LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("06/26/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced);
		//	people[5] = new Person("Chris Hemsworth", LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("08/11/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed);
		//	people[6] = new Person("Beyoncé Knowles", LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("09/04/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married);
		//	people[7] = new Person("Tom Hanks",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("07/09/2011"), LINQRefresher_v3.Enums.MaritalStatus.Married);
		//	people[8] = new Person("Shakira",         LINQRefresher_v3.Enums.Genders.Female, DateTime.Parse("02/02/2011"), LINQRefresher_v3.Enums.MaritalStatus.Widowed);
		//	people[9] = new Person("Brad Pitt",       LINQRefresher_v3.Enums.Genders.Male,   DateTime.Parse("12/18/2011"), LINQRefresher_v3.Enums.MaritalStatus.Divorced);
		//}

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
			//Assert.True(expected.SequenceEqual(actual));
			Assert.Equal(expected, actual);
		}

			//bool isTrue = actual.OrderBy(x => x).SequenceEqual(expected.OrderBy(x => x));
			//Assert.True(isTrue);

		//[Theory]
		//public void LINQRefresherTests(Student[] students)
		//{
		//	GetStudentsByGenderHappyPath();
		//}
	}
}