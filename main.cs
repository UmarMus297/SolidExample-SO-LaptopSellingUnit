using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSellingUnit
{
    class main
    {
        
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            List<Customer> CustomerList = new List<Customer>();
            List<Laptop> LaptopList = new List<Laptop>();  //Creating List of Laptop 
        start:
            Console.WriteLine("**************Welcome to the Laptop Corner*******************");
            Console.WriteLine("Please choose from following options?: ");
            Console.WriteLine("Are you Customer or Owner?");
            Console.WriteLine("Press 1 for Owner");
            Console.WriteLine("Press 2 for Customer");
            string getValue = Console.ReadLine();
            int userOption = Convert.ToInt32(getValue);
            int receiptId = 0;
            if (userOption == 2)
            {
                // AddCustomer
                var customer = Customer.GetCustomer();
                CustomerList.Add(customer);

                // Customer will select laptop
                Laptop.ShowAvailableLaptops(LaptopList);
                Console.WriteLine("Please select a laptop from the list: ");
                string chooseLaptop = Console.ReadLine();
                int selectedLaptop = Convert.ToInt32(chooseLaptop);

                /////// Customer has selected Laptop and now system has to generate Receipt
                Console.WriteLine("Please insert a quantity for selected laptop: ");
                string quantityLap = Console.ReadLine();
                int selectedQuantity = Convert.ToInt32(quantityLap);
                receiptId += 1;
                List<Receipt> ReceiptList = new List<Receipt>();
                Receipt receipt = new Receipt(receiptId, DateTime.Now, customer , LaptopList[selectedLaptop], selectedQuantity);
                ReceiptList.Add(receipt);
                Receipt.PrintReceipt(receipt, customer, LaptopList, selectedLaptop, selectedQuantity);
                Console.ReadKey();
                //For Printing short Receipt
                //for (int i = 0; i < ReceiptList.Count; i++) {
                //    //Receipt.PrintReceipt(receipt, customer, LaptopList, selectedLaptop, selectedQuantity);
                //    Console.WriteLine("Receipt id: " + ReceiptList[i].RecpNo);
                //    Console.WriteLine("Receipt date: " + ReceiptList[i].Receptdate);
                //    Console.WriteLine("Customer: " + customer.Name+ "\nCustomer Mobile No:" + customer.Mobile);
                //    Console.WriteLine("Laptop Brand: "+ LaptopList[selectedLaptop].brand);
                //    Console.WriteLine("Laptop Model: " + LaptopList[selectedLaptop].model);
                //    Console.WriteLine("Laptop Price: " + LaptopList[selectedLaptop].price);
                //    Console.WriteLine("Quantity: " + ReceiptList[i].QuantityLap);
                //}
                Console.ReadKey();
            }
            if (userOption == 1)
            {
                Console.Clear();
                //Adding Laptop in a shop
                Console.WriteLine("Inserting Laptop... ");
                Console.WriteLine("How many laptop you want to add in a shop?");
                string readingNoOfInputsToBeAdd = Console.ReadLine();
                int noOfLaptops = Convert.ToInt32(readingNoOfInputsToBeAdd);
                Console.WriteLine("\n  \n");
                for (int i = 0; i < noOfLaptops; i++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("For Laptop # " + i);
                    var newLaptop = Laptop.InsertLaptop();
                    LaptopList.Add(newLaptop);
                }
                Laptop.ShowAvailableLaptops(LaptopList);
                Console.WriteLine("These laptops are added in shop");
                goto start;
            }
        }
    }
}
