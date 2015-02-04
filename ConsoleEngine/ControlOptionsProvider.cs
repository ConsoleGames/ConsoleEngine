﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleEngine
{
    public abstract class ControlOptionsProvider<TControlOption>
    {
        public abstract bool CanGetControlOptions { get; }

        public abstract TControlOption GetControlOption();
    }
}