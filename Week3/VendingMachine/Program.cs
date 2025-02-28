using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>{{"Coke", 5 }, {"Pepsi", 3 }, {"Sprite", 10 }};
            VendingMachine vm = new VendingMachine("De Vest", inventory, 100.0f);
            
            Console.WriteLine(vm.CheckInventory("Coke"));

            Console.WriteLine(vm.Dispense("Coke", 1.0f));
            Console.WriteLine(vm.Dispense("Coke", 2.5f));

            Console.WriteLine(vm.CheckInventory("Coke"));

            Console.WriteLine(vm.CheckBalance());
            vm.AddFunds(25.7f);
            Console.WriteLine(vm.CheckBalance());

            vm.Restock("Coke", 31);
            vm.Restock("Fanta", 17);
            Console.WriteLine(vm.CheckInventory("Coke"));
            Console.WriteLine(vm.CheckInventory("Fanta"));
            

        }
    }
}
