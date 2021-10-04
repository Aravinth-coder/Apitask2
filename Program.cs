using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apitask2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            Console.WriteLine(" the calculate amount" + CalculateBillAmount(2, 77.8));
        }

        public static double CalculateBillAmount(int quantity, double price)
        {
            double payload;
            try
            {
              payload = price * quantity;
                return payload;
            }
            catch (Exception e)
            {
                return 0;
            }

        }

    }
    }




