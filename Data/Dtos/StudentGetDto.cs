namespace Data.Dtos
{
    public class StudentGetDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int StudentNumber { get; set; }
        public SchoolGetDto School { get; set; }
    }
}