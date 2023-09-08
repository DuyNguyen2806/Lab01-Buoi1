using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Person
    {
        protected string maSo, hoTen;
        public Person() { }

        public Person(string maSo, string hoTen)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
        }

        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public void Input()
        {
            Console.WriteLine("Nhap ma so ");
            MaSo = Console.ReadLine();
            Console.WriteLine("Nhap ho ten");
            hoTen = Console.ReadLine();
        }
        public void Output() { Console.WriteLine("Ma so {0}, Ho va Ten {1}", this.maSo, this.hoTen); }
    }
}
