﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class StackCell<T>
    {
        public T Value;
        public StackCell<T> Next;
    }
}
