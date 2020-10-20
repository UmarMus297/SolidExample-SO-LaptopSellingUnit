using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSellingUnit
{
    class Receipt
    {
        int ReceiptNo;
        DateTime ReceiptDate = DateTime.Now;
        int quantityLaptop;
        Customer cus1 = new Customer();
        Laptop lap1 = new Laptop();

        
        public Receipt(int recpno, DateTime date, Customer customer, Laptop laptop,int quantity)
        {
            ReceiptNo = recpno;
            ReceiptDate = date;
            quantityLaptop = quantity;
            customer = cus1;
         }


        public static void PrintReceipt(Receipt receipt, Customer customer, List<Laptop> laptops, int selectedLaptop, int quantity)
        {
            Console.WriteLine("************----------------Generating a Receipt for Customer----------------************");
            Console.WriteLine("Receipt No : " + receipt.RecpNo);
            Console.WriteLine("Receipt Date: " + receipt.Receptdate);
            Console.WriteLine("Customer Id: " + customer.Id);
            Console.WriteLine("Customer Name: " + customer.Name);
            Console.WriteLine("Customer Age: " + customer.Age);
            Console.WriteLine("Customer Profession: " + customer.Profession);
            Console.WriteLine("Customer Address: " + customer.Address);
            Console.WriteLine("Customer Mobile: " + customer.Mobile);
            Console.WriteLine("Laptop Brand: " + laptops[selectedLaptop].brand);
            Console.WriteLine("Laptop Model: " + laptops[selectedLaptop].model);
            Console.WriteLine("Laptop Memory: " + laptops[selectedLaptop].memory);
            Console.WriteLine("Laptop Graphic: " + laptops[selectedLaptop].graphic);
            Console.WriteLine("Laptop Harddisk: " + laptops[selectedLaptop].hardDisk);
            Console.WriteLine("Laptop SSD : " + laptops[selectedLaptop].ssdDrive);
            Console.WriteLine("Laptop Price: " + laptops[selectedLaptop].price);
            Console.WriteLine("Laptop Quantity: " + quantity);
            Console.WriteLine("Laptop Total Price: " + laptops[selectedLaptop].price * quantity);
            Console.WriteLine("*************Thank You for Shopping**************");
            Console.WriteLine("*************    #StayHome #StaySafe     **************");

        }

        public int RecpNo
        {
            get { return ReceiptNo; }
            set { ReceiptNo = value; }
        }

        public DateTime Receptdate
        {
            get { return ReceiptDate; }
            set { ReceiptDate = value; }
        }
        public Customer customer
        {
            get { return customer; }
            set { customer = value;  }
        }

        //public Customer customer { get; set; }
        public int QuantityLap {
            get { return quantityLaptop; }
            set { quantityLaptop = value; }
        }
    }
}
