using System;

namespace usecase7_Avoid_Duplicate_Entries
{
    class Program
    {
        static void Main(string[] args)
        {


                Console.WriteLine("Welcome To Address Book System!");
                Console.WriteLine("1.Enter to add the details");
                Console.WriteLine("2.Enter to modify the details");
                Console.WriteLine("3.Listing the details..");
                Console.WriteLine("4.Remove the details");
                Console.WriteLine("Enter a option");
               
                switch (Console.ReadLine())
                {
                    case "1":
                        AddrBook addr1 = new AddrBook();
                        addr1.GetCustomer("Naveeen","Kumar","8277284163","smg","shimoga","Karnataka","577203","naveen@gmail.com");
                        addr1.ListingPeople();
                        break;
                    case "2":
                        AddrBook addr2 = new AddrBook();
                        addr2.GetCustomer("Naveeen", "Kumar", "8277284163", "smg", "shimoga", "Karnataka", "577203", "naveen@gmail.com");
                        addr2.Modify();
                        addr2.ListingPeople();
                        break;
                    case "3":
                        AddrBook addr3 = new AddrBook();
                        addr3.GetCustomer("Naveeen", "Kumar", "8277284163", "smg", "shimoga", "Karnataka", "577203", "naveen@gmail.com");
                        addr3.ListingPeople();
                        break;
                    case "4":
                        AddrBook addr4= new AddrBook();
                        addr4.GetCustomer("Naveeen", "Kumar", "8277284163", "smg", "shimoga", "Karnataka", "577203", "naveen@gmail.com");
                        addr4.GetCustomer("Abhi", "Kumar", "8277284163", "smg", "shimoga", "Karnataka", "577203", "naveen@gmail.com");
                        addr4.RemovePeople();

                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }


        }


        
    }
}
