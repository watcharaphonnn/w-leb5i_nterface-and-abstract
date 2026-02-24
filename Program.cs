using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> participants = new List<Member>();
            List<Speaker> speakers = new List<Speaker>();

            while (true)
            {
                Console.WriteLine("\n Training Registration System ");
                Console.WriteLine("Select Role: 1.Student 2.Teacher 3.Guest 4.Exit");
                string choice = Console.ReadLine();

                if (choice == "4") break;

                Console.Write("Firstname: "); string fname = Console.ReadLine();
                Console.Write("Lastname: "); string lname = Console.ReadLine();
                Console.Write("Email: "); string email = Console.ReadLine();
                Console.Write("Phone: "); string phone = Console.ReadLine();

                if (choice == "1") // Student
                {
                    Student s = new Student();
                    s.SetBasicInfo(fname, lname, email, phone);
                    Console.Write("Student ID: "); s.StudentId = Console.ReadLine();
                    Console.Write("Major: "); s.Major = Console.ReadLine();
                    participants.Add(s);
                }
                else if (choice == "2") // Teacher
                {
                    Teacher t = new Teacher();
                    t.SetBasicInfo(fname, lname, email, phone);
                    Console.Write("Major: "); t.Major = Console.ReadLine();
                    Console.Write("Academic Position (Prof, etc.): "); t.Position = Console.ReadLine();

                    participants.Add(t);
                    Console.Write("Is this teacher a speaker? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y") speakers.Add(t);
                }
                else if (choice == "3") // Guest
                {
                    Guest g = new Guest();
                    g.SetBasicInfo(fname, lname, email, phone);
                    Console.Write("Company: "); g.Company = Console.ReadLine();
                    Console.Write("Job Position: "); g.JobPosition = Console.ReadLine();

                    participants.Add(g);
                    Console.Write("Is this guest a speaker? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y") speakers.Add(g);
                }
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("LIST OF PARTICIPANTS:");
            foreach (var member in participants)
            {
                Console.WriteLine(member.GetDetails());
            }

            Console.WriteLine("\nLIST OF SPEAKERS:");
            foreach (var speaker in speakers)
            {
                if (speaker is User u) Console.WriteLine($"- {u.GetFullName()}");
            }
            Console.WriteLine("========================================");
        }
    }
}
