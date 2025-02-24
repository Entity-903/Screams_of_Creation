using System;
using LINQRefresher_v3.Enums;

namespace LINQRefresher_v3.Models
{
    public class Student : Person
    {
		public Student(string name, Genders gender, DateTime birthdate, MaritalStatus relationship, int studentId, float gpa, ClassLevel level) : base(name, gender, birthdate, relationship)
		{
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Relationship = relationship;
            StudentId = studentId;
            GPA = gpa;
            Level = level;
		}

		public int StudentId { get; set; }
        public float GPA { get; set; }
        public ClassLevel Level { get; set; }

		//string name, Genders gender, DateTime birthdate, MaritalStatus relationship
		//public Student(Person person, int studentId, float gpa, ClassLevel level)
        //{
        //    Name = person.Name;
        //    Gender = person.Gender;
        //    Birthdate = person.Birthdate;
        //    Relationship = person.Relationship;
        //    StudentId = studentId;
        //    GPA = GPA;
        //    Level = level;
        //}
    }

    public class Person
    {
		public Person(string name, Genders gender, DateTime birthdate, MaritalStatus relationship)
		{
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Relationship = relationship;
		}

        //AGE - should be get only; use Birthdate to derive the value
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.Month < Birthdate.Month ||
                    (DateTime.Now.Month == Birthdate.Month && DateTime.Now.Day < Birthdate.Day))
                {
                    age--;
                }

                return age;
            }
        }
        public string Name { get; set; }
        public Genders Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public MaritalStatus Relationship { get; set; }
	}
}
