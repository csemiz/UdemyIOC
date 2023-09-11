﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Console
{
    class DAL:IDAL
    {
        public List<Product> GetProducts()
        {
            //SQL SERVER
            return new List<Product>()
            {
                new Product() {Id=1, Name="Kalem", Price=100, Stock=200 },
                new Product() {Id=2, Name="Kalem 2", Price=100, Stock=200 },
                new Product() {Id=3, Name="Kalem 3", Price=100, Stock=200 },
                new Product() {Id=4, Name="Kalem 4", Price=100, Stock=200 },
                new Product() {Id=5, Name="Kalem 5", Price=100, Stock=200 }
            };

        }




    }
}
