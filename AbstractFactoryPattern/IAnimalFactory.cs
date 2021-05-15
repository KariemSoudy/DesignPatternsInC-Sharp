﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_Sharp.AbstractFactoryPattern
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
