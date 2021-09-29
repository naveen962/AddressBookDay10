using System;
using System.Collections.Generic;

namespace AddressBookUC3
{
    class Program
    {
       
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the Addressbook  :   1->Addressbook1  2->Addressbook2");
                int res = int.Parse(Console.ReadLine());
                if (res == 1)
                {
                    AddressBookUC6.Addressbook1 ad1 = new AddressBookUC6.Addressbook1();
                    ad1.getaddressbook1();

                }
                else if (res == 2)
                {
                    AddressBookUC6.Addressbook2 ad2 = new AddressBookUC6.Addressbook2();
                    ad2.getaddressbook2();
                }
                else
                {
                    break;
                }
            }

        }


       
    }
}
