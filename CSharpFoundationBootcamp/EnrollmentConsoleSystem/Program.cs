
// Variables
String studentFirstName = "";
String studentLastName = "";
String studentMiddleInitial = "";
String courseName = "";
String studentDepartment = "";
String choice;

int studentID = 0;
int studentYear = 0;
int studentSemester = 0;
int studentAge = 0;

bool hasStudent = false;

Console.WriteLine("Welcome, User!");


do
{

    Console.WriteLine("==========MENU==========");
    Console.WriteLine("1. Add Student\n2.View Student\n3. Exit");
    Console.Write("Enter your choice: ");
    String input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Write("Enter Student First Name:");
            studentFirstName = Console.ReadLine();

            Console.Write("Enter Student Last Name:");
            studentLastName = Console.ReadLine();

            Console.Write("Enter Student Middle Initial:");
            studentMiddleInitial = Console.ReadLine();

            Console.Write("Enter Student Department:");
            studentDepartment = Console.ReadLine();

            Console.Write("Enter Student Course:");
            courseName = Console.ReadLine();

            Console.Write("Enter Student Age:");
            studentAge = int.Parse(Console.ReadLine());

            studentID++;

            Console.Write("Enter Student Year:");
            studentYear = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Semester:");
            studentSemester = int.Parse(Console.ReadLine());

            hasStudent = true;

            Console.WriteLine("Student information added successfully!");

            break;

        case "2":
            if (hasStudent)
            {
                String studentFullName = String.IsNullOrWhiteSpace(studentMiddleInitial) ? 
                        $"{studentFirstName} {studentLastName}" :
                        $"{studentFirstName} {studentMiddleInitial} {studentLastName}";
                Console.WriteLine("==========STUDENTS==========");
                Console.WriteLine($"Student ID:{studentID}");
                Console.WriteLine($"Student Name:{studentFullName}");
                Console.WriteLine($"Student Age:{studentAge}");
                Console.WriteLine();

                Console.WriteLine($"Department:{studentDepartment}");
                Console.WriteLine($"Course:{courseName}");
                Console.WriteLine($"Year:{studentYear}");
                Console.WriteLine($"Semester: {studentSemester}");
                Console.WriteLine("============================");

            }
            else
            {
                Console.WriteLine("No student information available. Please add a student first.");
            }
                break;
        case "3":
                Console.WriteLine("Exiting the program. Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            return;
    }

    Console.WriteLine("Do you want to continue? (y/n)");
    choice = Console.ReadLine();
}
while (choice.ToLower() == "y");


