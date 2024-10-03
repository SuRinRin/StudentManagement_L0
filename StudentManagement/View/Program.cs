using StudentManagement.Controller;

namespace StudentManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentManage manager = new StudentManage();
            while (true)
            {
				Console.WriteLine("\t\t\t\t+__________________________________________________________+");
				Console.WriteLine("\t\t\t\t|                                                          |");
				Console.WriteLine("\t\t\t\t|                                                          |");
				Console.WriteLine("\t\t\t\t|     __     __    ______     __     __     _     _        |");
				Console.WriteLine("\t\t\t\t|     ||\\   /||   |  ____|   |  \\   |  |   | |   | |       |");
				Console.WriteLine("\t\t\t\t|     || \\_/ ||   | |____    |  |\\  |  |   | |   | |       |");
				Console.WriteLine("\t\t\t\t|     ||     ||   |  ____|   |  | \\ |  |   | |   | |       |");
				Console.WriteLine("\t\t\t\t|     ||     ||   | |____    |  |  \\|  |   | |___| |       |");
				Console.WriteLine("\t\t\t\t|     ||     ||   |______|   |__|   \\__|   |_______|       |");
				Console.WriteLine("\t\t\t\t|                                                          |");
				Console.WriteLine("\t\t\t\t+----------------------------------------------------------+");
				Console.WriteLine("\t\t\t\t|                                                          |");
				Console.WriteLine("\t\t\t\t|    1.Add a new student                                   |");
				Console.WriteLine("\t\t\t\t|    2.Search for a student by ID                          |");
				Console.WriteLine("\t\t\t\t|    3.Update student by ID                                |");
				Console.WriteLine("\t\t\t\t|    4.Delete student by ID                                |");
				Console.WriteLine("\t\t\t\t|    5.Show percent academic performance                   |");
				Console.WriteLine("\t\t\t\t|    6.Show percent average score                          |");
				Console.WriteLine("\t\t\t\t|    7.Show list student by academic performance           |");
				Console.WriteLine("\t\t\t\t|    8.Save from file                                      |");
				Console.WriteLine("\t\t\t\t|    9.Read from file                                      |");
				Console.WriteLine("\t\t\t\t|    10.Show all students                                  |");
				Console.WriteLine("\t\t\t\t|    0. Exit program                                       |");
				Console.WriteLine("\t\t\t\t|                                                          |");
				Console.WriteLine("\t\t\t\t+----------------------------------------------------------+");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        manager.CreateStudent();
                        break;
                    case "2":
                        manager.GetStudentById();
                        break;
                    case "3":
                        manager.UpdateStudentById();
                        break;
                    case "4":
                        manager.DeleteStudentById();
                        break;
                    case "5":
                        manager.ShowPercentAcademicPerformance();
                        break;
                    case "6":
                        manager.ShowPercentGpa();
                        break;
                    case "7":
                        manager.ShowListStudentByAcademicPerformance();
                        break;
                    case "8":
                        manager.SaveToFile();
                        break;
                    case "9":
                        manager.ReadFromFile();
                        break;
                    case "10":
                        manager.ShowAllStudent();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
