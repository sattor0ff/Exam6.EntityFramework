using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class TeacherService
{
    private readonly DataContext _context;

    public TeacherService(DataContext context)
    {
        _context = context;
    }
    
    public List<TeacherDto> GetTeachers()
    {
        return _context.Teachers.Select(x=>new TeacherDto(x.TeacherId,x.Email,x.Password,x.Name,x.DOB,x.Sex,x.Address,x.Phone,x.DateOfJoin)).ToList();
    }
    
    public void AddTeacher(TeacherDto teacher)
    {
        try
        {
            var added = new Teacher(teacher.TeacherId, teacher.Email, teacher.Password, teacher.Name, teacher.DOB, teacher.Sex, teacher.Address, teacher.Phone, teacher.DateOfJoin);
        _context.Teachers.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateTeacher(TeacherDto teacher)
    {
        try
        {
            var updated = new Teacher(teacher.TeacherId, teacher.Email, teacher.Password, teacher.Name, teacher.DOB, teacher.Sex, teacher.Address, teacher.Phone, teacher.DateOfJoin);
        _context.Teachers.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteTeacher(int id)
    {
        var deleted = _context.Teachers.First(x => x.TeacherId == id);
        _context.Teachers.Remove(deleted);
        _context.SaveChanges();
    }
}