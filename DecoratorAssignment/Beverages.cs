using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment
{
    public abstract class Beverage
    {
        //Description can be retrieved by anyone, can only be set from whithin Beverage class, can be overwritten by subclasses
        public virtual string Description { get; protected set; } = " ";

        //cost variable to use in sublasses
        public abstract double Cost();
    }
    //HouseBlend subclass with description and price
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }

    //DarkRoast subclass with description and price
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }

    //Decaf subclass with description and price
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }

    //Espresso subclass with description and price
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
























}
