using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTChatAdventure.assets
{
    class Room
    {
        public static string Type { get; set; }
        public static string Description { get; set; } = "none";
        public List<string> Items { get; set; } = new List<string>();
        public List<string> Enemies { get; set; } = new List<string>();

        public Room(string type, string description)
        {
            Type = type;
            Description = description;
        }

        public void RoomInfo()
        {
            Console.WriteLine($"Room Type: {Type}");
            Console.WriteLine($"Room Description: {Description}");
            Console.WriteLine("Items in Room: " + (Items.Count > 0 ? string.Join(", ", Items) : "Empty"));
            Console.WriteLine("Enemies in Room: " + (Enemies.Count > 0 ? string.Join(", ", Enemies) : "None"));
            // Display inventory eventually
        }
    }
}
