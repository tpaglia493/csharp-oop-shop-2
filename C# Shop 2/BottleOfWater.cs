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
            this.remainingWater = bottleCapacity;
            this.open = false;

        }

        //STATES
        private bool open;
        private float remainingWater;

        //SETTERS 
        public void openBottle()
        {
            if (open) 
            {
                Console.WriteLine("The bottle is already open");
            } 
            else 
            { 
            this.open = true; 
            }

        }

        public void closeBottle()
        {
            if (!open)
            {
                Console.WriteLine("The bottle is already closed");
            }
            else
            {
                this.open = false;
            }
        }

        //GETTERS
        public bool isBottleOpen()
        {
            return this.open;
        }



        //METHODS
        public override string GetProductInfo()
        {
            string info = base.GetProductInfo();
            info += $"Bottle Size: {bottleCapacity} L \n";
            return info;


        }
    }
}
