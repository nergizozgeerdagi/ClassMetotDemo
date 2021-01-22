using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 117,
                name = "Nergiz Özge",
                LastName = "Erdağı",


            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(customer);
            musteriManager.list(customer);
            musteriManager.Sil(customer);

            MusteriYazi musteriyazi = new MusteriYazi();

            musteriyazi.Yazdir(musteriyazi);



           


        }     
    }
}

    class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string LastName { get; set; }
        
    }

    class MusteriManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(" ( " + customer.Id + " - " + customer.name + " " + customer.LastName + " ) " + "Müşteri eklendi.");
        }

        public void list(Customer customer)
        {
            Console.WriteLine(customer.name + " " + customer.LastName + " " + "Listelendi.");
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.name + " " + customer.LastName + " " + "Listeden silindi.");
        }

    }

    class MusteriYazi
    {
        public string yazi { get; set; }
    
    public void Yazdir(MusteriYazi musteriyazi)
         
        {
        string yazi = "İyi ve sağlıklı günler dileriz.";
        Console.WriteLine(yazi);
        }
    }
   

