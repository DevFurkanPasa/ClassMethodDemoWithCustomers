using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Operator
    {
        public void StartOfSystem()
        {
            CustomerManager manager = new CustomerManager(new Customer());
            
            for (int i = 0; i < 1; i--)
            {
                Console.WriteLine("-----------DevFurkanTopal v0.1----------");
                Console.WriteLine();
                Console.WriteLine("Müşterileri görüntülemek için --------> 1'e basınız.");
                Console.WriteLine("Müşteri eklemek için -----------------> 2'e basınız.");
                Console.WriteLine("Müşteri silmek için ------------------> 3'e basınız.");
                Console.WriteLine("Programı kapatmak için ---------------> 4'e basınız.");

                try
                {
                    int istek = Convert.ToInt32(Console.ReadLine());

                    if (istek == 1)
                    {
                        manager.ListOfCustomers();
                        Console.WriteLine();
                        Console.WriteLine("Sisteme geri dönmek için herhangi bir tuşa basın..");
                        Console.ReadLine();
                        Utility.Clear();
                    }
                    else if (istek == 2)
                    {
                        manager.Add();
                        Console.WriteLine();
                        Console.WriteLine("Sisteme geri dönmek için herhangi bir tuşa basın..");
                        Console.ReadLine();
                        Utility.Clear();
                    }
                    else if (istek == 3)
                    {
                        manager.Delete();
                        Console.WriteLine();
                        Console.WriteLine("Sisteme geri dönmek için herhangi bir tuşa basın..");
                        Console.ReadLine();
                        Utility.Clear();
                    }
                    else if (istek == 4)
                    {
                        i = 10;
                        Console.Write("İşlemler Kaydediliyor.");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Console.WriteLine();
                        Console.Write("Çıkış yapılıyor.");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Console.WriteLine();
                        Utility.Message.Show();
                    }
                    else
                    {

                        Console.Write("Hata Alındı Tekrar Deneyin!");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Utility.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.Write("Sistem bir hataya maruz kaldı. Yeniden Başlatılıyor.");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Utility.Clear();
                }
            }
        }
    }
}
