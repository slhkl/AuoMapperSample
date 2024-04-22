namespace Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        public DateTime Birthday { get; set; }
        public School School { get; set; }
    }
}