using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> StuList = new List<Student>();
            bool e = false;
            while (!e) {
                Console.WriteLine("===Menu===");
                Console.WriteLine("1. Them SV");
                Console.WriteLine("2. Hien thi ds SV");
                Console.WriteLine("3. Xuat SV thuoc khoa CNTT");
                Console.WriteLine("4. Xuat SV DTB > 5");
                Console.WriteLine("5. SortStuByAvrScore ");
                Console.WriteLine("6..Danh sach SV co DTB hon 5 va thuoc khoa CNTT ");
                Console.WriteLine("7. Danh sach SV co DTB cao nhat va thuoc khoa CNTT ");
                Console.WriteLine("8. So luong tung loai xep hang ");
                Console.WriteLine("0. Thoat");
                string choice = Console.ReadLine(); 
                switch (choice)
                {
                    case "1":
                        AddStudent(StuList);
                        break;
                    case "2":
                        DisplayStuList(StuList);
                        break;
                    case "3":
                        DisplayStuCNTT(StuList); 
                        break;
                    case "4":
                        DisplayStuAvr5(StuList);
                        break;
                    case "5":
                        SortStuByAvrScore(StuList);
                        break;
                    case "6":
                        DisplayStuByFalAndScore(StuList, "CNTT", 5);
                        break;
                    case "7":
                        DisplayStuByFalAndMaxScore(StuList, "CNTT");
                        break;
                    case "8":
                        SoLuongTungLoai(StuList);
                        break;

                    case "0":
                        e= true;
                        Console.WriteLine("Ket thuc ");
                        break;
                    default: Console.WriteLine("Tuy chon khong hop le.Vui long chon lai");
                        break;
                }
            }
        }

       
        private static void SoLuongTungLoai(List<Student> stuList)
        {
            var XepLoaiSinhVien = stuList.Select(s =>
            {
                if (s.AvrScore >= 9) return "Xuat sac";
                else if (s.AvrScore >= 8) return "Gioi";
                else if (s.AvrScore >= 7) return "Kha";
                else return "Trung binh";

            });
            var SoLuongXepLoai =XepLoaiSinhVien.GroupBy(xl=>xl).ToDictionary(gr=>gr.Key, gr=>gr.Count());
            foreach(var xl in SoLuongXepLoai)
            {
                Console.WriteLine($"{xl.Key}: {xl.Value} Sinh Vien");
            }
            
        }

        private static void DisplayStuByFalAndMaxScore(List<Student> stuList, string falculty)
        {
            Console.WriteLine("Danh sach sinh vien co diem trung binh cao nhat va thuoc khoa {0}", falculty);
            var maxAvr = stuList.Where(s=>s.Faculty.Equals(falculty, StringComparison.OrdinalIgnoreCase))
                                                 .Max(s=>s.AvrScore);

            List<Student> listStuMaxAvr = stuList.Where(s=>s.AvrScore == maxAvr).ToList();
            DisplayStuList(listStuMaxAvr);
        }

        private static void DisplayStuByFalAndScore(List<Student> stuList, string falcuty, float minAvr)
        {
            Console.WriteLine("Danh sach SV co DTB lon hon {0} va thuoc khoa {1}",minAvr,falcuty);
            List<Student> listStubyAvrAndFal = stuList.Where(s => s.AvrScore >= minAvr && s.Faculty.Equals(falcuty, StringComparison.OrdinalIgnoreCase)).ToList();
            if (listStubyAvrAndFal.Count != 0)
            {
                DisplayStuList(listStubyAvrAndFal);
            }else Console.WriteLine("Khong co SV");
        }

        private static void SortStuByAvrScore(List<Student> stuList)
        {
            Console.WriteLine("Danh sach SV sap xep tang dan theo DTB");
            List<Student> listStubyAvr = stuList.OrderBy(s=>s.AvrScore).ToList();
            DisplayStuList(listStubyAvr);
        }

        private static void DisplayStuAvr5(List<Student> stuList)
        {
            List<Student> stuAvr = stuList.Where(s=>s.AvrScore>=5).ToList();
            if (stuList.Count != 0)
            {
                DisplayStuList(stuAvr);
            }else Console.WriteLine("Khong co sv");
        }

        private static void DisplayStuList(List<Student> stuList)
        {
            Console.WriteLine("Danh sach sinh vien");
            foreach (Student stu in stuList)
            {
                stu.Show();
            }
        }

        static void AddStudent(List<Student> stuList)
        {
            Console.WriteLine("Nhap thong tin sv");
            Student student = new Student();
            student.Input();
            stuList.Add(student);
            Console.WriteLine("Thanh cong");
        }
        static void DisplayStuCNTT(List<Student> stuList)
        {
            /* List<Student> studentsCNTT = (from s in stuList where s.Faculty == "CNTT" select s).ToList();*/
            List<Student> studentsCNTT = stuList.Where(s=>s.Faculty.Equals("CNTT", StringComparison.OrdinalIgnoreCase)).ToList();
            if (stuList.Count != 0)
            {
                DisplayStuList(studentsCNTT);
            }
            else { Console.WriteLine("Khong co sv"); }
        }
        
    }
}
