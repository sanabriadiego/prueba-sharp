namespace prueba_proyecto_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. List Students");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    studentService.AddStudent(name);
                    Console.WriteLine("Student added successfully.");
                }
                else if (choice == "2")
                {
                    List<Student> students = studentService.GetStudents();
                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                    }
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
}
