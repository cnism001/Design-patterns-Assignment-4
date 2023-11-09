using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment
{
    //Subclass to hold the condiments for Beverages-class objects
    public abstract class Condiment : Beverage
    {
        //gets description from condiments:sublacc members and doesnt interfere with Beverage description
        public abstract override string Description { get; }
    }
    //Subclass inheriting from Condiment subclass
    public class SteamedMilk : Condiment
    {   
        //Beverage object, can only be set during initialization
        private readonly Beverage _beverageComponent;

        //simple constructor for SteamedMilk
        public SteamedMilk(Beverage beverageComponent)
        {
            _beverageComponent = beverageComponent;
        }
        //Appends  Beverage description with description of the condiment
        public override string Description => _beverageComponent.Description + ", wih Steamed Milk";

        //Adds the cost of the condiment to the cost of the Beverage
        public override double Cost()
        {
            return _beverageComponent.Cost() + 0.20;
        }
    }























}
