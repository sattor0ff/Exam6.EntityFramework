namespace Domain.Dtos;

public class ClassroomDto
{
    public int ClassroomId { get; set; }
    public string Section { get; set; }
    public int Grade { get; set; }
    public int TeacherId { get; set; }
    public int TimeTableId { get; set; }

    public ClassroomDto()
    {
        
    }

    public ClassroomDto(int classroomid, string section, int grade, int teaherid, int timetableid)
    {
        ClassroomId = classroomid;
        Section = section;
        Grade = grade;
        TeacherId = teaherid;
        TimeTableId = timetableid;
    }
}