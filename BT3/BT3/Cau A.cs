using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Cau_A
    {
        static void CauA()
        {
            Phanso p1 = new Phanso();
            Console.WriteLine("-------Nhap thong tin phan so thu 1:");
            Console.Write("Nhap tu so:");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            int mauso = int.Parse(Console.ReadLine());
            p1.settuso(tuso);
            p1.setmauso(mauso);
            Console.WriteLine("Nhap thong tin mau so thu 2:");
            Console.Write("Nhap tu so:");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            mauso = int.Parse(Console.ReadLine());

        }
    }
}
