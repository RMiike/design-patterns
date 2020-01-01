﻿using System;
using StrategyPatternOne.Interface;

namespace StrategyPatternOne.Behaviors.FlyBehaviors
{
    
        class FlyRocketPowered : IFlyBehavior
        {
            public void fly()
            {
                Console.WriteLine("I'm flying with a rocket!");
            }
        }
    
}
