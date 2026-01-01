using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace MySpace_Inventory.Services
{

    public class Program_product
    {
        public string Printer { get; set; }
        public string Product { get; set; }
        public int Time { get; set; }
        public int Priority { get; set; }
        public string FinishHour { get; set; }

        public Program_product(string printer, string product, int time, int priority)
        {
            Printer = printer;
            Product = product;
            Time = time;
            Priority = priority;
            FinishHour = DateTime.Now.AddHours(time).ToString("HH:mm");
        }
        
    }
}
