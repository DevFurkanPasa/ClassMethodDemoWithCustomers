using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Utility
    {
        //Sistem yeniden başlatma komutu ekle..
        public static class Message
        {
            public static void Show()
            {
                Console.WriteLine("DevFurkanTopal iyi günler diler!");
            }
            public static void Show(string text)
            {
                Console.WriteLine(text);
            }
        }
        public static void Clear()
        {
            //Ne? Kontrol altına almak istedim tamam mı?
            //Bana göre gereksiz değil :)
            Console.Clear();
        }

        public static void Control()
        {
            UserClass user = new UserClass();
            user.UserName = "Athena";
            user.Password = "14159265";

            Console.WriteLine("Kullanıcı adı giriniz.");
            string name = Console.ReadLine();

            Console.WriteLine("Kullanıcı şifresi giriniz.");
            string password = Console.ReadLine();

            if (name == user.UserName && password == user.Password)
            {
                Console.WriteLine("Kaydınız onaylandı. 2 saniye içinde sistem başlatılacak!");
                Thread.Sleep(1000);
                Clear();
                Operator @operator = new Operator();
                @operator.StartOfSystem();
            }
            else
            {
                Console.WriteLine("Kaydınız onaylanmadı. İyi günler!");
            }
        }

    }
}
