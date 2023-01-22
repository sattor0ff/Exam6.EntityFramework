using System.ComponentModel.DataAnnotations;
namespace Domain.Entites;


public class ClassroomStudent
{
    [Key]
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int ClassroomId { get; set; }
    public Student Student { get; set; }
    public Classroom Classroom { get; set; }

    public ClassroomStudent()
    {
        
    }
    
    public ClassroomStudent(int id, int studentid, int classroomid)
    {
        Id = id;
        StudentId = studentid;
        ClassroomId = classroomid;
    }
}