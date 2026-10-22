using ReverseEngineering.Models;

namespace ReverseEngineering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new();
            var student = dbContext.Students.FirstOrDefault(s => s.Id == 3);
            Console.WriteLine(student);
        }
    }
}
