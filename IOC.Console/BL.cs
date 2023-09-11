using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Console
{
     class BL
     {
        private IDAL _dal {  get; set; }
        public BL(IDAL dal) //ctor
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
     }
}
