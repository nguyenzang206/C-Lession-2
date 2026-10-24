using WinFormsApp2.data.entity;

namespace WinFormsApp2.data.DAO;

public class StudentDataAccess
{
    private readonly SchoolDataStore _store;

    public StudentDataAccess(SchoolDataStore store)
    {
        _store = store;
    }

    public List<Student> GetAll()
    {
        return _store.Students.ToList();
    }

    public Student? GetById(string studentId)
    {
        return _store.Students.FirstOrDefault(student =>
            student.StudentId.Equals(studentId, StringComparison.OrdinalIgnoreCase));
    }

    public List<Student> GetByClassCode(string classCode)
    {
        return _store.Students
            .Where(student => string.Equals(student.Class?.Code, classCode, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Student> SearchByStudentId(string keyword)
    {
        return _store.Students
            .Where(student => student.StudentId.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Student> Search(string field, string keyword)
    {
        return _store.Students.Where(student => field switch
        {
            "StudentId" => Contains(student.StudentId, keyword),
            "FullName" => Contains(student.FullName, keyword),
            "Email" => Contains(student.Email, keyword),
            "Class" => Contains(student.Class?.Code, keyword),
            _ => true
        }).ToList();
    }

    public void Add(Student student)
    {
        _store.Students.Add(student);
    }

    public void Update(Student student)
    {
        var existingStudent = GetById(student.StudentId);
        if (existingStudent is null)
        {
            return;
        }

        existingStudent.FullName = student.FullName;
        existingStudent.Email = student.Email;
        existingStudent.DateOfBirth = student.DateOfBirth;
        existingStudent.Phone = student.Phone;
        existingStudent.Score = student.Score;
        existingStudent.Status = student.Status;
        existingStudent.Class = student.Class;
    }

    public bool Delete(string studentId)
    {
        var student = GetById(studentId);
        return student is not null && _store.Students.Remove(student);
    }

    private static bool Contains(string? value, string keyword)
    {
        return value?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true;
    }
}
