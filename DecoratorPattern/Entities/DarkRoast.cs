﻿

namespace DecoratorPattern.Entities
{
    class DarkRoast : Beverage
    {

        string _description = "Dark Roast Coffe";
    
        public override double cost()
        {
            return .99;
        }

        public override string getDescription
        {
            get { return _description; }
        }

    }
}
