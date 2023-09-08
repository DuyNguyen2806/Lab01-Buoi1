using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2A
{
    internal class Student
    {
        private string studentID;
        private string fullName;
        private float avrScore;
        private string faculty;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AvrScore { get => avrScore; set => avrScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public Student(string studentID, string fullName, float avrScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.avrScore = avrScore;
            this.faculty = faculty;
        }
        public Student() { }    
        public void Input()
        {
            Console.WriteLine("Nhap MSSV");
            StudentID = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh");
            AvrScore =float.Parse( Console.ReadLine()); 
            Console.WriteLine("Nhap khoa");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0}, Ho Ten:{1}, DiemTB: {2}, Khoa: {3}  ", this.StudentID, this.FullName, this.AvrScore, this.Faculty);     
        }
    }
}
