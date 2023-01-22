using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class StudentService
{
    private readonly DataContext _context;

    public StudentService(DataContext context)
    {
        _context = context;
    }
    
    public async Task<List<StudentDto>> GetStudents()
    {
        return await _context.Students.Select(x=>new StudentDto(x.StudentId,x.Email,x.Password,x.Name,x.DOB,x.Sex,x.Address,x.Phone,x.DateOfJoin,x.ParentName)).ToListAsync();
    }
    
    public async Task AddStudent(StudentDto student)
    {
        try
        {
            var added = new Student(student.StudentId, student.Email, student.Password, student.Name, student.DOB, student.Sex, student.Address, student.Phone, student.DateOfJoin, student.ParentName);
        await _context.Students.AddAsync(added);
        await _context.SaveChangesAsync();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public async Task UpdateStudent(StudentDto student)
    {
        try
        {
            var updated = new Student(student.StudentId, student.Email, student.Password, student.Name, student.DOB, student.Sex, student.Address, student.Phone, student.DateOfJoin, student.ParentName);
        _context.Students.Update(updated);
        await _context.SaveChangesAsync();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        } 
    }
    public async Task DeleteStudent(int id)
    {
        var deleted = _context.Students.First(x => x.StudentId == id);
        _context.Students.Remove(deleted);
        await _context.SaveChangesAsync();
    }
}