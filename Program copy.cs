using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Homework7 Output Start ===\n");

            
            Customer c1 = new Customer(110, "Alice", 28);
            Customer c2 = new Customer(111, "Bob", 30);

            Console.WriteLine("[Initial Customer Information]");
            c1.PrintCusInfo();
            c2.PrintCusInfo();
            Console.WriteLine();

            
            c1.ChangeID(220);
            c2.ChangeID(221);

            Console.WriteLine("[After Updating Customer IDs]");
            c1.PrintCusInfo();
            c2.PrintCusInfo();
            Console.WriteLine();

            
            Console.WriteLine("[Compare Ages]");
            c1.CompareAge(c2);

            Console.WriteLine("\n=== Homework7 Output End ===");
        }
    }

    class Customer
    {
        private int cus_id;
        public string cus_name;
        public int cus_age;

        public Customer(int cus_id, string cus_name, int cus_age)
        {
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        public void ChangeID(int new_id)
        {
            this.cus_id = new_id;
        }

        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer Info -> ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
        }

        public void CompareAge(Customer objCustomer)
        {
            if (this.cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"Older customer: {this.cus_name}");
            }
            else if (this.cus_age < objCustomer.cus_age)
            {
                Console.WriteLine($"Older customer: {objCustomer.cus_name}");
            }
            else
            {
                Console.WriteLine("Both customers are the same age.");
            }
        }
    }
}