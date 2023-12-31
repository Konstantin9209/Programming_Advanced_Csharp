﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_boxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.PricePerBox = item.Price * itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split(' ');
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber, currentItem, itemQuantity);
                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(box => box.PricePerBox).ToList();


            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:F2}");
            }
        }
    }
}
