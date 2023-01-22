namespace Domain.Entites;

public class Classroom
{
    public int ClassroomId { get; set; }
    public string Section { get; set; }
    public int Grade { get; set; }
    public int TeacherId { get; set; }
    public int TimeTableId { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<ClassroomStudent> ClassroomStudents { get; set; }
    public Teacher Teacher { get; set; }
    public TimeTable TimeTable { get; set; }

    public Classroom()
    {
        
    }

    public Classroom(int classroomid, string section, int grade, int teacherid, int tametableid)
    {
        ClassroomId = classroomid;
        Section = section;
        Grade = grade;
        TeacherId = teacherid;
        TimeTableId = tametableid;
    }
}