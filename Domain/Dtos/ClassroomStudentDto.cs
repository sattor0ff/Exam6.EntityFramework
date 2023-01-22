namespace Domain.Dtos;

public class ClassroomStudentDto
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int ClassroomId { get; set; }

    public ClassroomStudentDto()
    {
        
    }
    public ClassroomStudentDto(int id, int studentid, int classroomid)
    {
        Id = id;
        StudentId = studentid;
        ClassroomId = classroomid;
    }
   
}