using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("900111", "Le Van Teo", 600);
            Console.WriteLine("Inter id value");
            string id = Console.ReadLine();
            Console.WriteLine("Inter id value");
            string name = Console.ReadLine();
            Console.WriteLine("Inter id value");
            int balance = int.Parse(Console.ReadLine());
            Account myFriend = new Account(id, name, balance);
            Console.WriteLine("-----Thong tin 2 tai khoan ban dau------");
            Console.WriteLine("My Account:[ id:{0}, name: {1}, balance:{2}]",
            my.getid(), my.getname(), my.getbalance());
            Console.WriteLine("My friend Account:[ id:{e}, name: {1}, balance:{2}]",
            myFriend.getid(), myFriend.getname(), myFriend.getbalance());
            int amout = 0;
            //rut tien
            Console.WriteLine("Debit 200 from my Account");
            my.debit(200);
            //Chuyển tiền
            Console.WriteLine("Inter a amount value to tranfer:");
            amout = int.Parse(Console.ReadLine());
            //Chuyen khoản từ tài khoản My đến Myfriend
            my.tranfeTo(myFriend, amout);
            //Chuyen khoản từ tài khoản My friend đến My 
            my.tranfeTo(myFriend, 50);
            //ket qua sau khi thuc hien mot so hanh vi (nap, rut, chuyen khoan)
            Console.WriteLine("-----Thong tin 2 tai khoan sau khi thuc hien giao dich-----");
            Console.WriteLine("My Account:[ id:{0}, name: (1}, balance: {2}]",
            my.getid(), my.getname(), my.getbalance());
            Console.WriteLine("My friend Account:[ id:{0}, name:{1}, balance:{2}]",
            myFriend.getid(), myFriend.getname(), myFriend.getbalance());
            Console.ReadLine();
        }
    }
}
