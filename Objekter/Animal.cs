﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekter
{
    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void AnimalSound();
    }
}
