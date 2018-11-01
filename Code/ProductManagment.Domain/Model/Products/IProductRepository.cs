using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagment.Domain.Model.Products.GenericProducts;

namespace ProductManagment.Domain.Model.Products
{
    public interface IProductRepository
    {
        //void Add<T>(T product)
        void Add(GenericProduct product);
    }
}
