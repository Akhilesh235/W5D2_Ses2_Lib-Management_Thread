using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W5D2_Training_Ses2
{
    class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }

        public Student(int id, string name)     //constructor
        {
            studentID = id;
            studentName = name;
        }

    }

    class Book
    {
        public string bookTitle { get; set; }
        public int bookID { get; set; }

        public Book(string bkName, int bkID)
        {
            bookTitle = bkName;
            bookID = bkID;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continue_loop = true;
            List<Student> StudentsInLib = new List<Student>();
            List<Book> BooksInLib = new List<Book>();
            while (continue_loop)
            {
                Console.WriteLine("Welcome to Library");
                Console.WriteLine("Choose option : ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Book : ");
                Console.WriteLine("3. Borrow Book : ");
                Console.WriteLine("4. Return Book : ");

                int choose = int.Parse(Console.ReadLine());

                
              

                switch (choose)
                {
                    case 1:
                        {
                            Thread addstudent = new Thread(new ThreadStart(AddStudent));
                            addstudent.Start();

                            break;
                        }

                    case 2:
                        {
                            Thread addbook = new Thread(new ThreadStart(AddBook));
                            addbook.Start();
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }


            }

        }

        public static void AddStudent()
        {
            Console.WriteLine("Enter Student ID");
            int studentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string studentName = Console.ReadLine();

            Student stdnt = new Student(studentID, studentName);
            StudentsInLib.Add(stdnt);
        }

        public static void AddBook()
        {
            Console.WriteLine("Enter Book Title");
            string booktitle = Console.ReadLine();
        }
    }
}
