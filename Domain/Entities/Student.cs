namespace Domain.Entites;

public class Student
{
    public int StudentId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public string Sex { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string DateOfJoin { get; set; }
    public string ParentName { get; set; }
    public List<AttendanceStudent> AttendanceStudents { get; set; }
    public List<Issue> Issues { get; set; }

    public Student()
    {
        
    }

    public Student(int studentid, string email, string password, string name, DateTime dob, string sex, string address, string phone, string dateofjoin, string parentname)
    {
        StudentId = studentid;
        Email = email;
        Password = password;
        Name = name;
        DOB = dob;
        Sex = sex;
        Address = address;
        Phone = phone;
        DateOfJoin = dateofjoin;
        ParentName = parentname;
    }
}

