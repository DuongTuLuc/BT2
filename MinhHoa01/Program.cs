using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoa01
{
    class Diem
    {
        public int x;
        public int y;
        //phương thức nhập toạ độ
        public void NhapToaDoDiem()
        {
            Console.Write("\t -Nhập hoành độ x :");
            x = int.Parse(Console.ReadLine());
            Console.Write("\t -Nhập tung độ y :");
            y = int.Parse(Console.ReadLine());
        }
        //Phương thức tính khoảng cách hai điểm
        public double TinhKhoangCach(Diem p)
        {
            double kc;
            kc = Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2));
            return kc;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Diem A, B;
                A = new Diem();
                B = new Diem();
                Console.WriteLine("--Nhập toạ độ điểm A:");
                A.NhapToaDoDiem();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("--Nhập toạ độ điểm B:");
                B.NhapToaDoDiem();
                Console.WriteLine("--------------------------------------");
                double Kq = A.TinhKhoangCach(B);
                Console.WriteLine(" *Khoảng cách hai điểm: {0} ", Kq);
                Console.ReadLine();
            }
        }
    }
}
