using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSellingUnit
{
    class Laptop
    {
        string Brand;
        string Model;
        string Memory;
        string GraphicCard;
        string HDDsize;
        string SSD;
        int Price;

        public Laptop()
        {
        }

        public Laptop(string brand, string model, string memory, string gcard, string hardDrive, string SsdDrive, int price)
        {
            Brand = brand;
            Model = model;
            Memory = memory;
            GraphicCard = gcard;
            HDDsize = hardDrive;
            SSD = SsdDrive;
            Price = price;
        }

        public static Laptop InsertLaptop()
        {
            Console.WriteLine("Please Enter Laptop brand name: ");
            string laptopBrand = Console.ReadLine();
            Console.WriteLine("Please Enter Laptop model: ");
            string laptopModel = Console.ReadLine();
            Console.WriteLine("Please Enter Laptop Ram memory: ");
            string ramMemory = Console.ReadLine();
            Console.WriteLine("Please Enter Laptop Graphic Card size: ");
            string graphicMemory = Console.ReadLine();
            Console.WriteLine("Please Enter Laptop Hard drive size: ");
            string Hddsize = Console.ReadLine();
            Console.WriteLine("Please Enter Laptop SSD size: ");
            string ssdsize = Console.ReadLine();
            Console.WriteLine("Please Enter Laptop price: ");
            string price = Console.ReadLine();
            int LaptopPrice = Convert.ToInt32(price);
            Laptop currentLaptop = new Laptop(laptopBrand, laptopModel, ramMemory, graphicMemory, Hddsize, ssdsize, LaptopPrice);
            return currentLaptop;
        }

        public static void ShowAvailableLaptops(List<Laptop> laptops)
        {
            Console.WriteLine("Please select a laptop from availabe list");
            for (int i = 0; i < laptops.Count; i++)
            {
                Console.WriteLine("Laptop # " + i);
                Console.WriteLine("Brand " + laptops[i].brand);
                Console.WriteLine("Model:  " + laptops[i].model);
                Console.WriteLine("Memory: " + laptops[i].memory);
                Console.WriteLine("Graphics:  " + laptops[i].graphic);
                Console.WriteLine("Harddisk: " + laptops[i].hardDisk);
                Console.WriteLine("SSD Drive: " + laptops[i].ssdDrive);
                Console.WriteLine("Price  " + laptops[i].price);
                Console.WriteLine("---------------------");
            }
        }

        public string brand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public string model
        {
            get { return Model; }
            set { Model = value; }
        }

        public string memory
        {
            get { return Memory; }
            set { Memory = value; }
        }

        public string graphic
        {
            get { return GraphicCard; }
            set { GraphicCard = value; }
        }

        public string hardDisk
        {
            get { return HDDsize; }
            set { HDDsize = value; }
        }

        public string ssdDrive
        {
            get { return SSD; }
            set { SSD = value; }
        }

        public int price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}
