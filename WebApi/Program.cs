using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>(conf => conf.UseNpgsql(connection));

builder.Services.AddControllers();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<TeacherService>();
builder.Services.AddScoped<AttendanceStudentService>();
builder.Services.AddScoped<AttendanceTeacherService>();
builder.Services.AddScoped<IssueService>();
builder.Services.AddScoped<TimeTableService>();
builder.Services.AddScoped<ExamService>();
builder.Services.AddScoped<ClassroomService>();
builder.Services.AddScoped<ClassroomStudentService>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<ResultService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
