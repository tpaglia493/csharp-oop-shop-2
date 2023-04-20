using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_2
{
    public class BottleOfWater : Product
    {
        //ATTRIBUTES

        private float bottleCapacity;
        private float pH;
        private string waterSource;

        //CONSTRUCTOR
        public BottleOfWater( string commercialName, string description, float price, float iva, Category categoryName, float bottleCapacity, float pH, string waterSource) 
            :base(commercialName,  description,  price,  iva,  categoryName)
        {
            this.waterSource = waterSource;
            this.pH = pH;   
            this.bottleCapacity = bottleCapacity;

        } 
    }
}
