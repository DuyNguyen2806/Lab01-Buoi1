using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Teacher : Person
    {
        private string diaChi;
        public Teacher(){}
        public Teacher(string diaChi) 
        {
            this.DiaChi = diaChi;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public void InputTeacher()
        {
            Input();
        }
    }
}
