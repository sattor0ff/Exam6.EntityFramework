using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Student> Students {get; set;}
    public DbSet<Teacher> Teachers {get; set;}
    public DbSet<AttendanceStudent> AttendanceStudents { get; set; }
    public DbSet<AttendanceTeacher> AttendanceTeachers { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<TimeTable> TimeTables { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<ClassroomStudent> ClassroomStudents { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Result> Results { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}