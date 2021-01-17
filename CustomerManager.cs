using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        Customer _customer;
        SqlServer _server = new SqlServer();
        public CustomerManager(Customer customer)
        {
            _customer = customer;
            Console.WriteLine("Bizi Tercih ettiğiniz için teşekkürler!!");
            
        }
        
        public void Add()
        {
            Customer customer = new Customer();
            Console.WriteLine("Müşteri ekleme operasyonu başladı.");

            Console.WriteLine("Müşteri ismini giriniz. :");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("Müşteri soy ismini giriniz. :");
            customer.LastName = Console.ReadLine();

            Console.WriteLine("Müşteri yaşını giriniz. :");
            try
            {
                customer.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Yaş bilgisi eklenemedi. Müşteri eklemeye devam edebilirsiniz.");
                
            }

            Console.WriteLine("Müşteri e-postasını giriniz. :");
            customer.Email = Console.ReadLine();

            Console.WriteLine("Müşteri telefon numarasını giriniz. :");
            customer.PhoneNumber = Console.ReadLine();
            
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "adlı müşteri sisteme eklenmiştir");
            Utility.Message.Show();
        }

        public void Delete()
        {
            Customer[] customers = _server.ListOfCustomers();
            int i = 1;
            Console.WriteLine("Müşteri silme operasyonu başlatıldı!");
            Console.WriteLine("Devam Etmek için bir tuşa basın..");
            Console.ReadLine();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " ID'ye sahip Müşteri : " + customer.FirstName + " " + customer.LastName);
            }
            Console.WriteLine("Silmek istediğiniz müşterinin ID'sini yazınız");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (Customer customer in customers)
                {
                    if (customer.Id == id)
                    {
                        Console.WriteLine(customer.FirstName + " " + customer.LastName + " müşteri listesinden silinmiştir.");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("İşlemde bir hata oluştu. Sistem yeniden başlatılıyor..");
            }
        }

        public void ListOfCustomers()
        {      
            Customer[] customers =_server.ListOfCustomers();
            int i = 1;
            foreach (Customer customer in customers)
            {
                Console.WriteLine(i + ". Müşteri : " +customer.FirstName+" "+customer.LastName);
                i++;
            }
        }

    }
}
