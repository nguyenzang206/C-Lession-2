using WinFormsApp2.data.entity;

namespace WinFormsApp2.data.DAO;

public class ClassDataAccess
{
    private readonly SchoolDataStore _store;

    public ClassDataAccess(SchoolDataStore store)
    {
        _store = store;
    }

    public List<ClassModel> GetAll()
    {
        return _store.Classes.ToList();
    }

    public ClassModel? GetByCode(string code)
    {
        return _store.Classes.FirstOrDefault(classModel =>
            classModel.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(ClassModel classModel)
    {
        _store.Classes.Add(classModel);
    }

    public void Update(ClassModel classModel)
    {
        var existingClass = GetByCode(classModel.Code);
        if (existingClass is null)
        {
            return;
        }

        existingClass.Name = classModel.Name;
    }

    public bool HasStudents(string code)
    {
        return _store.Students.Any(student =>
            string.Equals(student.Class?.Code, code, StringComparison.OrdinalIgnoreCase));
    }

    public bool Delete(string code)
    {
        var classModel = GetByCode(code);
        return classModel is not null && _store.Classes.Remove(classModel);
    }
}
