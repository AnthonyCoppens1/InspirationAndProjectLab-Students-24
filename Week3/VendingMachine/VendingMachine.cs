using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        public string Location { get; set; }
        public Dictionary<string,int> Inventory { get; set; }
        public float Balance { get; set; }

        public VendingMachine(string location, Dictionary<string,int> inventory, float balance)
        {
            Location = location;
            Inventory = inventory;
            Balance = balance;
        }

        public string CheckInventory(string itemName)
        {
            if (Inventory.ContainsKey(itemName))
            {
                return $"{Inventory[itemName]}";
            }
            else
            {
                return "Item not found.";
            }
        }

        public string Dispense(string itemName, float amountPaid)
        {
            if (Inventory.ContainsKey(itemName) && Inventory[itemName] > 0 && amountPaid >= 2.5f)
            {
                Inventory[itemName]--;
                Balance += amountPaid;
                return "Please take your item.";
            }
            else if (Inventory.ContainsKey(itemName) && Inventory[itemName] > 0 && amountPaid < 2.5f)
            {
                return "Amount paid is not enough.";
            }
            else
            {
                return "Item not available.";
            }
        }

        public float CheckBalance()
        {
            return Balance;
        }

        public void AddFunds(float amount)
        {
            Balance += amount;
        }

        public void Restock(string itemName, int quantity)
        {
            if (Inventory.ContainsKey(itemName))
            {
                Inventory[itemName] += quantity;
            }
            else
            {
                Inventory[itemName] = quantity;
            }
        }
    }
}
