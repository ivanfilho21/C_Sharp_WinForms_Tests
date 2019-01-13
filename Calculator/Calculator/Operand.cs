using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{

    class Operand
    {
        public double value;
        public double Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
                this.HasValue = true;
            }
        }
        public bool HasValue { get; private set; }

        public Operand()
        {
            this.HasValue = false;
        }
    }
}
