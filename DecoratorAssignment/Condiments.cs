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

























}
