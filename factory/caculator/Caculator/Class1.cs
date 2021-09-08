using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public enum OperatorType
    {
        add = 0,
        sub = 1,
        multiple = 2,
        division = 3
    }

    public class Operation
    {

        private double _numberA = 0;
        private double _numberB = 0; 

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        public virtual double getResult()
        {
            double result = 0;
            return result;
        }
    }


    class OperationAdd:Operation
    {
        public override double getResult()
        {

            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    class OperationSub:Operation
    {
        public override double getResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }


    class OperationMultiple:Operation
    {
        public override double getResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    class OperationDivision:Operation
    {
        public override double getResult()
        {
            double result = 0;
            if (NumberB != 0)
                result = NumberA / NumberB;
            else
                throw new Exception("除数不能为0。");

            return result;
        }
    }


    class OperationSqrt:Operation
    {
        public override double getResult()
        {
            return base.getResult();
        }

    }

    // Simple Factory Pattern
    public class OperationFactory
    {
    
        public static Operation createOperate( OperatorType operatorType)
        {
            Operation oper = null;
            switch(operatorType)
                {

                case (OperatorType.add):
                    {
                        oper = new OperationAdd();
                        break;
                     }

                case (OperatorType.sub):
                    {
                        oper = new OperationSub();
                        break;
                    }
               case(OperatorType.multiple):
                    {
                        oper = new OperationMultiple();
                        break;
                    }

                case (OperatorType.division):
               {
                        oper = new OperationDivision();
                        break;
               }
                default:
                    
                    throw new Exception("无对应运算实现！！");
                   

            }
            return oper;
        }
    }
}
