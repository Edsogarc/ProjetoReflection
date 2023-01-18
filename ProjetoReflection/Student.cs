
namespace ProjetoReflection
{
    public class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} - {University} - {RollNumber}";
        }
    }
}
