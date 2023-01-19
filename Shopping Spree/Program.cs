﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Spree
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> product = new List<Product>();
            List<string> peopleInfo = Console.ReadLine().Split(' ').ToList();
            foreach(var item in peopleInfo)
            {
                string[] info = item.Split('=');
                Person currentPerson = new Person(info[0], decimal.Parse(info[1]));
                people.Add(currentPerson);
            }
            List<string> productInfo = Console.ReadLine().Split(' ').ToList();
            foreach (var item in productInfo)
            {
                string[] info = item.Split('=');
                Product currentProduct= new Product(info[0], decimal.Parse(info[1]));
                product.Add(currentProduct);
            }
            string command = Console.ReadLine();
            while(command!="END")
            {
                List<string> elements = command.Split(' ').ToList();
                string personName = elements[0];
                string productName = elements[1];
                Person currentPerson = people.FirstOrDefault(p => p.Name == personName);
                Product currentProduct = product.FirstOrDefault(p => p.Name == productName);
                currentPerson.AddProduct(currentProduct);
                command = Console.ReadLine();
            }
            foreach(var item in product)
            {
                Console.WriteLine(item);
            }
        }
    }
}
