using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTChatAdventure.assets
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public List<string> Inventory { get; set; } = new List<string>();

        public Player(string name)
        {
            Name = name;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Player: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine("Enemies in Room: " + (Inventory.Count > 0 ? string.Join(", ", Inventory) : "None"));
        }
    }
}
