using System;
using System.Collections.Generic;

namespace AddressBookUC6
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
                Console.WriteLine("Select the Addressbook  :   1->Addressbook1  2->Addressbook2  3->Addressbook3");
                int res = int.Parse(Console.ReadLine());
                if (res == 1)
                {
                    Addressbook addressbook1 = new Addressbook();
                    addressbook1.getaddressbook();

                }
                else if (res == 2)
                {
                    Addressbook addressbook2 = new Addressbook();
                    addressbook2.getaddressbook();
                }
                else if (res == 3)
                {
                    Addressbook addressbook3 = new Addressbook();
                    addressbook3.getaddressbook();
                }
                else
                {
                    break;
                }
            }

        }


       
    }
}
