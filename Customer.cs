using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSellingUnit
{
    public class Customer
    {
        int cusID;
        string cusName;
        int cusAge;
        string cusProfession;
        string cusAddress;
        string cusMobileNo;

        public static Customer GetCustomer()
        {
            Console.WriteLine("Please Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter your age: ");
            string askAge = Console.ReadLine();
            int age = Convert.ToInt32(askAge);
            Console.WriteLine("Please Enter your Profession: ");
            string occupation = Console.ReadLine();
            Console.WriteLine("Please Enter your Address: ");
            string addressOfCustomer = Console.ReadLine();
            Console.WriteLine("Please Enter your Mobile number: ");
            string mobNo = Console.ReadLine();
            Console.Clear();
            int id = 0;
            Customer currentCustomer = new Customer() { Id = id++, Name = name, Age = age, Profession = occupation, Address = addressOfCustomer, Mobile = mobNo };
            return currentCustomer;
        }
        public string Name
        {
            get { return cusName; }
            set { cusName = value; }
        }

        public int Age
        {
            get { return cusAge; }
            set { cusAge = value; }
        }

        public string Profession
        {
            get { return cusProfession; }
            set { cusProfession= value; }
        }

        public string Address
        {
            get { return cusAddress; }
            set { cusAddress = value; }
        }

        public string Mobile
        {
            get { return cusMobileNo; }
            set { cusMobileNo = value; }
        }

        public int Id {
            get { return cusID; }
            set { cusID = value; }
        }
        
    }
}
