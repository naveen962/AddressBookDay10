using System;
using System.Collections.Generic;

namespace AddressBookUC2
{
    class Program
    {
        public static long Phonenumber;
        public static int zipcode;
        static public string Firstname, Lastname, City, State, Email;
        /// <summary>
        /// The addressbook
        /// </summary>
        static public Dictionary<int, Contact> addressbook = new Dictionary<int, Contact>();

        /// <summary>
        /// Adds the record.
        /// </summary>
        public void AddRecord()
        {

            Console.WriteLine("Enter Firstname");
            Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            Lastname = Console.ReadLine();
            Console.WriteLine("Enter  City");
            City = Console.ReadLine();
            Console.WriteLine("Enter  State");
            State = Console.ReadLine();
            Console.WriteLine("Enter Email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            zipcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            Phonenumber = long.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------");

        }
        /// <summary>
        /// Displays the address book.
        /// </summary>
        /// <returns></returns>
        void DisplayAddressBook()
        {
            foreach (KeyValuePair<int, Contact> kvp in addressbook)
            {
                Console.WriteLine("KEY: " + kvp.Key);
                Console.WriteLine("Name :{0} {1}", kvp.Value.Firstname, kvp.Value.Lastname);
                Console.WriteLine("Address :{0},{1},{2}", kvp.Value.City, kvp.Value.Zipcode, kvp.Value.State);
                Console.WriteLine("Phone number: {0}", kvp.Value.Phonenumber);
                Console.WriteLine("----------------------------------------------------------");
            }
        }

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            Console.WriteLine("<-----------------Welcome To Address Book------------------->");

            int temp = 0;
            Program p = new Program();

            while (true)
            {
                Console.WriteLine("Enter your choice :1->AddRecord 2->exit ");
                int choice = int.Parse(Console.ReadLine());
                if(choice==1)
                { 
                        p.AddRecord();
                        Contact contact = new Contact(Firstname, Lastname, City, State, Email, Phonenumber, zipcode);
                        temp = temp + 1;
                        addressbook.Add(temp, contact);
                        p.DisplayAddressBook();

                }
                else
                {
                    break;
                }
            }

        }

    }


    class Contact
    {
        public string Firstname, Lastname, City, State, Email;
        public int Zipcode;
        public long Phonenumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="fn">The function.</param>
        /// <param name="ln">The ln.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="email">The email.</param>
        /// <param name="phno">The phno.</param>
        /// <param name="zip">The zip.</param>
        public Contact(string fn, string ln, string city, string state, string email, long phno, int zip)
        {
            Firstname = fn;
            Lastname = ln;
            City = city;
            State = state;
            Email = email;
            Phonenumber = phno;
            Zipcode = zip;
        }
    }
}

