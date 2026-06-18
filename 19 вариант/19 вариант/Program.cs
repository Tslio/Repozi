using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_вариант
{
    internal class Program
    {
    static void Main()
        {
            Student student = new Student("Григорий");
            student.ExamPassed += ShowResult;
            student.ExamPassed += ShowIfPassed;
            student.PassExam(5);
        }
        static void ShowResult(object sender, ExamEventArgs e)
        {
            Console.WriteLine(
                "Студент: " + e.StudentName +
                " получил оценку " + e.Mark
            );
        }
        static void ShowIfPassed(object sender, ExamEventArgs e)
        {
            Console.WriteLine(
                "экзамен сдан"
            );
        }
    }
    class Student
    {
        public string Name {get; set; }
        public event EventHandler<ExamEventArgs> ExamPassed;
        public Student(string name)
        {
            Name = name;
        }
        public void PassExam(int mark)
        {
            ExamEventArgs args =
                new ExamEventArgs(Name, mark);
            ExamPassed?.Invoke(this, args);
        }
    }
    class ExamEventArgs : EventArgs
    {
        public string StudentName {get;}
        public int Mark {get;}
        public ExamEventArgs(string name, int mark)
        {
            StudentName = name;
            Mark = mark;
        }
    }
}