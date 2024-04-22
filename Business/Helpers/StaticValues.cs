using Data.Models;

namespace Business.Helpers
{
    public class StaticValues
    {
        #region Singleton

        public static StaticValues Instance = new Lazy<StaticValues>(() => new StaticValues()).Value;

        #endregion

        #region Constructors

        private StaticValues()
        {
            var students = new List<Student>();

            for (int i = 0; i < 10000; i++)
            {
                students.Add(new Student
                {
                    Id = i,
                    Name = i + ".",
                    Surname = "Student",
                    Birthday = DateTime.Now,
                    Number = Random.Shared.Next(),
                    School = new School
                    {
                        Id = 1,
                        Name = 1 + ". School",
                        Country = "Turkiye",
                        Type = 2
                    }
                });
            }
            StudentList = students;
        }

        #endregion

        #region Properties

        public List<Student> StudentList { get; private set; }

        #endregion
    }
}
