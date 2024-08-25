namespace StudentProjectAPI.Entity
{    public class Student
    {
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_Email { get; set; }
        public int Mobile_number { get; set; }
        public string Student_Address { get; set; }
        public DateTime admission_date { get; set; }
        public decimal fees;
        public bool Status;
    }
}
