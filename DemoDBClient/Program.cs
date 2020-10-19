using System;
using System.Collections.Generic;
using System.Configuration;
using DemoDBDataAccessLayer.Data;
using DemoDBDataAccessLayer.Models;

namespace DemoDBClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonData personData = new PersonData();


            foreach (var item in people)
            {
                Console.WriteLine(item.Firstname + " " + item.Lastname);
            }

            Console.ReadLine();
        }
    }
}
