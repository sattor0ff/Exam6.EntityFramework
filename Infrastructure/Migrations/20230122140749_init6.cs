using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_Teachers_TeacherId",
                table: "Classroom");

            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_TimeTables_TimeTableId",
                table: "Classroom");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudent_Classroom_ClassroomId",
                table: "ClassroomStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudent_Students_StudentId1",
                table: "ClassroomStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Classroom_ClassroomId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomStudent",
                table: "ClassroomStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom");

            migrationBuilder.RenameTable(
                name: "ClassroomStudent",
                newName: "ClassroomStudents");

            migrationBuilder.RenameTable(
                name: "Classroom",
                newName: "Classrooms");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomStudent_StudentId1",
                table: "ClassroomStudents",
                newName: "IX_ClassroomStudents_StudentId1");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomStudent_ClassroomId",
                table: "ClassroomStudents",
                newName: "IX_ClassroomStudents_ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_TimeTableId",
                table: "Classrooms",
                newName: "IX_Classrooms_TimeTableId");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_TeacherId",
                table: "Classrooms",
                newName: "IX_Classrooms_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomStudents",
                table: "ClassroomStudents",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Teachers_TeacherId",
                table: "Classrooms",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_TimeTables_TimeTableId",
                table: "Classrooms",
                column: "TimeTableId",
                principalTable: "TimeTables",
                principalColumn: "TimeTableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudents_Classrooms_ClassroomId",
                table: "ClassroomStudents",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudents_Students_StudentId1",
                table: "ClassroomStudents",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Classrooms_ClassroomId",
                table: "Subject",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Teachers_TeacherId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_TimeTables_TimeTableId",
                table: "Classrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudents_Classrooms_ClassroomId",
                table: "ClassroomStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudents_Students_StudentId1",
                table: "ClassroomStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Classrooms_ClassroomId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomStudents",
                table: "ClassroomStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms");

            migrationBuilder.RenameTable(
                name: "ClassroomStudents",
                newName: "ClassroomStudent");

            migrationBuilder.RenameTable(
                name: "Classrooms",
                newName: "Classroom");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomStudents_StudentId1",
                table: "ClassroomStudent",
                newName: "IX_ClassroomStudent_StudentId1");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomStudents_ClassroomId",
                table: "ClassroomStudent",
                newName: "IX_ClassroomStudent_ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_Classrooms_TimeTableId",
                table: "Classroom",
                newName: "IX_Classroom_TimeTableId");

            migrationBuilder.RenameIndex(
                name: "IX_Classrooms_TeacherId",
                table: "Classroom",
                newName: "IX_Classroom_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomStudent",
                table: "ClassroomStudent",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classroom_Teachers_TeacherId",
                table: "Classroom",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classroom_TimeTables_TimeTableId",
                table: "Classroom",
                column: "TimeTableId",
                principalTable: "TimeTables",
                principalColumn: "TimeTableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudent_Classroom_ClassroomId",
                table: "ClassroomStudent",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudent_Students_StudentId1",
                table: "ClassroomStudent",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Classroom_ClassroomId",
                table: "Subject",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
