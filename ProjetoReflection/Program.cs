using ProjetoReflection;
using System.Reflection;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        DisplayPublicProperties();
    }

    public static void DisplayPublicProperties()
    {
        PropertyInfo[] propertyInfos = CreateInstance().GetType().GetProperties();
        Console.WriteLine(CreateInstance());
        foreach (PropertyInfo propertyInfo in propertyInfos)
        {
            Console.WriteLine($"Propriedade {propertyInfo.Name}, do tipo '" +
                $"{propertyInfo.PropertyType.Name}'");
        }
    }
    public static Student CreateInstance()
    {
        Student student = Activator.CreateInstance<Student>();
        PropertyInfo[] propertyInfos = student.GetType().GetProperties();
        foreach (PropertyInfo propertyInfo in propertyInfos)
        {
            if (propertyInfo.Name == "Name")
            {
                propertyInfo.SetValue(student, "Edson");
            }
            if (propertyInfo.Name == "University")
            {
                propertyInfo.SetValue(student, "Univesp");
            }
            if (propertyInfo.Name == "RollNumber")
            {
                propertyInfo.SetValue(student, 3);
            }
        }
        return student;
    }
}
