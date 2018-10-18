using System.Collections.Generic;

namespace ProductMagment.Model
{
 

    public abstract class BaseProduct:BaseEntit<long>
    {
        public string Name { get; set; }
        public BaseProduct Parent { get; set; }
        public List<Constarint> Constarints { get; set; }

        protected BaseProduct(string name)
        {
            Name = name;
        }
       
        protected abstract void AddProduct(BaseProduct baseProduct);
    }

    public class GenericProduct : BaseProduct
    {
        private readonly List<BaseProduct> _baseProducts;

       
        protected override void AddProduct(BaseProduct baseProduct)
        {
           this._baseProducts.Add(baseProduct);
        }

        public GenericProduct(string name) : base(name)
        {
        }
    }

    public class Constarint :BaseProduct
    {
        public string Title { get; set; }


        private  List<BaseProduct> _baseProducts;

     
        protected override void AddProduct(BaseProduct baseProduct)
        {
            
           _baseProducts.Add(baseProduct); 
        }


        public Constarint(string name) : base(name)
        {
        }
    }

    public class ConstraintType:BaseEntit<long>
    {
        public string Title { get; set; }
    }

    public class ActualProduct
    {

    }

    public class BaseEntit<T>
    {
        public T Id { get; set; }
    }

  

}
