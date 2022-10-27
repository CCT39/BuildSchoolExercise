using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Q5_StudentObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student mohammad = new Student()
            {
                Id = "60723031L",
                Name = "穆莫德",
            };

            Student ibrahim = new Student()
            {
                Id = "40821056R",
                Name = "易布欣",
            };

            mohammad.AddCourse("消費地理學", 3);
            mohammad.AddCourse("食物地理學", 2);

            ibrahim.AddCourse("地理思想", 3);
            ibrahim.AddCourse("空間資料庫", 3);
            ibrahim.AddCourse("地理論著評讀", 1);

            mohammad.ShowStudentInfo();
            ibrahim.ShowStudentInfo();

            Console.ReadLine();
        }
    }

    class Student
    {
        private string id = "";
        private readonly static string idPattern = @"^[0-9]{8}[A-Za-z]{1}$";
        private readonly static int maxCourses = 16;

        public string Id
        {
            get { return id; }
            set 
            {
                if (Regex.IsMatch(value, idPattern))
                    id = value;
                else
                    id = "00000000A";
            }
        }
        public string Name { get; set; }
        
        string[,] classAndCredits = new string[maxCourses, 2];

        public void AddCourse(string course, int credits)
        {
            for (int i = 0; i < maxCourses; i++)
            {
                if (classAndCredits[i, 0] == null && classAndCredits[i, 1] == null)
                {
                    classAndCredits[i, 0] = course;
                    classAndCredits[i, 1] = credits.ToString();
                    break;
                }
            }
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("學號：" + Id);
            Console.WriteLine("姓名：" + Name);
            ShowCourses();
        }

        public void ShowCourses()
        {
            Console.WriteLine("選課：");
            int sum = 0;

            for (int i = 0; i < maxCourses; i++)
            {
                if (classAndCredits[i, 0] != null && classAndCredits[i, 1] != null)
                {
                    Console.WriteLine("\t" + classAndCredits[i, 0] + "，" + classAndCredits[i, 1] + "學分");
                    sum += Convert.ToInt32(classAndCredits[i, 1]);
                }
            }

            Console.WriteLine($"總共{sum}學分");
            Console.WriteLine($"------------------------");
        }
    }
}
