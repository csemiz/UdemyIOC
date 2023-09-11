using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Console
{
    class OracleDAL:IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {Id=1, Name="Oracle Kalem", Price=100, Stock=200 },
                new Product() {Id=2, Name="Oracle Kalem 2", Price=100, Stock=200 },
                new Product() {Id=3, Name="Oracle Kalem 3", Price=100, Stock=200 },
                new Product() {Id=4, Name="Oracle Kalem 4", Price=100, Stock=200 },
                new Product() {Id=5, Name="Oracle Kalem 5", Price=100, Stock=200 }
            };
        }

    }
}
