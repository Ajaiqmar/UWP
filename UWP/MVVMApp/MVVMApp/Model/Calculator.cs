using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class Calculator
    {
        public int LeftOperand;
        public int RightOperand;

        public Calculator(int leftOperand,int rightOperand)
        {
            this.LeftOperand = leftOperand;
            this.RightOperand = rightOperand;
        }

        public int Add()
        {
            return this.LeftOperand + this.RightOperand;
        }

        public int Sub()
        {
            return this.LeftOperand - this.RightOperand;
        }

        public int Mul()
        {
            return this.LeftOperand * this.RightOperand;
        }

        public int Div()
        {
            return this.LeftOperand / this.RightOperand;
        }
    }
}
