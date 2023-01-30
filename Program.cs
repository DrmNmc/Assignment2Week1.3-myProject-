using System;
using System.Reflection.Metadata;
using System.Transactions;

namespace myProject
{
    class myProject
    {
        static void Main(string[] args)
        {

            SchoolProject sp1 = new SchoolProject();
            sp1.Id = 119;
            sp1.Instructor = ("Doebek");
            sp1.Title = ("Astronomy");
            
            SchoolProject sp2 = new SchoolProject();
            Console.WriteLine("Please enter the class ID(number only): ");
            sp2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the instructor's name: ");
            sp2.Instructor = Console.ReadLine();
            Console.WriteLine("Please enter the class title: ");
            sp2.Title = Console.ReadLine();

            SchoolProject sp3 = new SchoolProject(195, "Balbach", "Web Applications");

            Console.WriteLine("Please enter the class ID(number only): ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the instructor's name: ");
            string tempInstructor = Console.ReadLine();
            Console.WriteLine("Please enter the class name: ");
            string tempTitle = Console.ReadLine();
            SchoolProject sp4 = new SchoolProject(tempID, tempInstructor, tempTitle);

            displayMembers(sp1);
            displayMembers(sp2);
            displayMembers(sp3);
            displayMembers(sp4);

        }
        static void displayMembers(SchoolProject item)
        {
            Console.WriteLine($"Class List: ");
            Console.WriteLine($"Class ID: {item.Id}");
            Console.WriteLine($"Instructor: {item.Instructor}");
            Console.WriteLine($"Class Title: {item.Title}");

        }
    }
    class SchoolProject
    {
        private int _Id;
        private string _Instructor;
        private string _Title;

        public SchoolProject() { }

        public SchoolProject(int id, string Instructor, string title)
        {
            _Id = id;
            _Instructor = Instructor;
            _Title = title;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Instructor
        {
            get { return _Instructor; }
            set { _Instructor = value; }
        }
    }
}