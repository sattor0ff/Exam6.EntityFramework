using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudents_Students_StudentId1",
                table: "ClassroomStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Exams_ExamId1",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Students_StudentId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Subject_SubjectId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Classrooms_ClassroomId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomStudents",
                table: "ClassroomStudents");

            migrationBuilder.DropIndex(
                name: "IX_ClassroomStudents_StudentId1",
                table: "ClassroomStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_ExamId1",
                table: "Result");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Result",
                newName: "Results");

            migrationBuilder.RenameColumn(
                name: "StudentId1",
                table: "ClassroomStudents",
                newName: "ClassroomStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_ClassroomId",
                table: "Subjects",
                newName: "IX_Subjects_ClassroomId");

            migrationBuilder.RenameColumn(
                name: "ExamId1",
                table: "Results",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Result_SubjectId",
                table: "Results",
                newName: "IX_Results_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Result_StudentId",
                table: "Results",
                newName: "IX_Results_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "ClassroomStudents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ClassroomStudentId",
                table: "ClassroomStudents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Results",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Results",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomStudents",
                table: "ClassroomStudents",
                column: "ClassroomStudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomStudents_StudentId",
                table: "ClassroomStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ExamId",
                table: "Results",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudents_Students_StudentId",
                table: "ClassroomStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Subjects_SubjectId",
                table: "Results",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Classrooms_ClassroomId",
                table: "Subjects",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomStudents_Students_StudentId",
                table: "ClassroomStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Subjects_SubjectId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Classrooms_ClassroomId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomStudents",
                table: "ClassroomStudents");

            migrationBuilder.DropIndex(
                name: "IX_ClassroomStudents_StudentId",
                table: "ClassroomStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_ExamId",
                table: "Results");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Results",
                newName: "Result");

            migrationBuilder.RenameColumn(
                name: "ClassroomStudentId",
                table: "ClassroomStudents",
                newName: "StudentId1");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_ClassroomId",
                table: "Subject",
                newName: "IX_Subject_ClassroomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Result",
                newName: "ExamId1");

            migrationBuilder.RenameIndex(
                name: "IX_Results_SubjectId",
                table: "Result",
                newName: "IX_Result_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_StudentId",
                table: "Result",
                newName: "IX_Result_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "ClassroomStudents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId1",
                table: "ClassroomStudents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "Result",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ExamId1",
                table: "Result",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomStudents",
                table: "ClassroomStudents",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomStudents_StudentId1",
                table: "ClassroomStudents",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Result_ExamId1",
                table: "Result",
                column: "ExamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomStudents_Students_StudentId1",
                table: "ClassroomStudents",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Exams_ExamId1",
                table: "Result",
                column: "ExamId1",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Students_StudentId",
                table: "Result",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Subject_SubjectId",
                table: "Result",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Classrooms_ClassroomId",
                table: "Subject",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
