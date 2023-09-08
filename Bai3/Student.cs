using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student : Person
    {
        private float avrScore;
        private string faculty;

        public Student()
        {
        }

        public Student(string maSo, string hoTen) : base(maSo, hoTen)
        {
        }

        public Student(float avrScore, string faculty)
        {
            this.avrScore = avrScore;
            this.faculty = faculty;
        }

        public float AvrScore { get => avrScore; set => avrScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public void InputSV()
        {
            Input();
            Console.WriteLine("Nhap diem tbc ");
            AvrScore = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa");
            Faculty = Console.ReadLine();   
        }
        public void OutputSV()
        {
            Output();
            Console.Write("Diem trung binh {0}, Khoa {1}", this.avrScore, this.faculty);
        }
    }
}
