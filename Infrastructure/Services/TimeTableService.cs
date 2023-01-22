using Domain.Dtos;
using Domain.Entites;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class TimeTableService
{
    private readonly DataContext _context;

    public TimeTableService(DataContext context)
    {
        _context = context;
    }
    
    public List<TimeTableDto> GetTimeTables()
    {
        return _context.TimeTables.Select(x=>new TimeTableDto(x.TimeTableId, x.Day, x.Time, x.Subject)).ToList();
    }
    
    public void AddTimeTable(TimeTableDto timetable)
    {
        try
        {
            var added = new TimeTable()
        {
            TimeTableId = timetable.TimeTableId,
            Day = timetable.Day,
            Time = timetable.Time,
            Subject = timetable.Subject
        };
        _context.TimeTables.Add(added);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void UpdateTimeTable(TimeTableDto timetable)
    {
        try
        {
            var updated = new TimeTable(timetable.TimeTableId, timetable.Day, timetable.Time, timetable.Subject);
        _context.TimeTables.Update(updated);
        _context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            throw;
        }
        
    }
    public void DeleteTimeTable(int id)
    {
        var deleted = _context.TimeTables.First(x => x.TimeTableId == id);
        _context.TimeTables.Remove(deleted);
        _context.SaveChanges();
    }
}