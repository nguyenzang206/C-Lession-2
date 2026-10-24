using WinFormsApp2.data.entity;

namespace WinFormsApp2.data.DAO;

public class SchoolDataStore
{
    internal List<Student> Students { get; } = new();
    internal List<ClassModel> Classes { get; } = new();

    public SchoolDataStore()
    {
        var classes = new[]
        {
            new ClassModel { Code = "CSE1000", Name = "CSE1000 - Sample" },
            new ClassModel { Code = "CSE1001", Name = "CSE1001 - Sample" },
            new ClassModel { Code = "CSE2002", Name = "CSE2002 - Sample" },
            new ClassModel { Code = "CSE3003", Name = "CSE3003 - Sample" }
        };
        Classes.AddRange(classes);

        var students = new[]
        {
            new Student { StudentId = "SV1000", FullName = "Nguyen Van A", Email = "a.van@example.com", DateOfBirth = new DateTime(2000, 1, 15), Phone = "0901234567", Score = 8.5, Status = "Active", Class = classes[0] },
            new Student { StudentId = "SV1001", FullName = "Tran Thi B", Email = "b.tran@example.com", DateOfBirth = new DateTime(1999, 5, 30), Phone = "0912345678", Score = 7.2, Status = "Active", Class = classes[1] },
            new Student { StudentId = "SV1002", FullName = "Le Van C", Email = "c.le@example.com", DateOfBirth = new DateTime(2001, 3, 20), Phone = "0987654321", Score = 9.1, Status = "Inactive", Class = classes[0] },
            new Student { StudentId = "SV1003", FullName = "Pham Thi D", Email = "d.pham@example.com", DateOfBirth = new DateTime(2002, 11, 5), Phone = "0977123456", Score = 6.0, Status = "Active", Class = classes[2] }
        };

        Students.AddRange(students);
        foreach (var student in students)
        {
            student.Class!.Students.Add(student);
        }
    }
}
