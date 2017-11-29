using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wrox{
    public struct Dimensions
    {
        public double Length;
        public double Width;
    }
    class AsMainEntryPoint
    {
        static void Main()
        {
            // try calling some static functions.
            Console.WriteLine("Pi is " + MathTest.GetPi());
            int x = MathTest.GetSquareOf(5);
            Console.WriteLine("Square of 5 is " + x);

            //Instantiate a MathTest object
            MathTest math = new MathTest();
            //math.GetValue() = 30;
            math.Value=30;
            Console.WriteLine("value field of math variable contains " + math.Value);
            Console.WriteLine("Square of 30 is " + math.GetSquare());

            Dimensions instance;
            instance.Length = 5.0;
            instance.Width = 6.0;
            Console.WriteLine("Area of Dimensions's instance is " + MathTest.GetArea(ref instance));

            //DateTime date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            //Console.WriteLine(date1.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1.ToString(System.Globalization.CultureInfo.InvariantCulture));
            // Displays 01/03/2008 07:00:00

            var captain = new { FirstName = "James", MiddleName = "T", LastName = "Krik" };
            Console.WriteLine(captain);

            int i = -50;
            string str = i.ToString();
        }
    }
    //Define a class named MathTest on which we will call a method
    class MathTest
    {
        
        private int m_testNumber;

        public int Value
        {
            get
            {
                return m_testNumber;
            }
            set
            {
                if(value>0)
                {
                    m_testNumber = value;
                }
            }
        }

        public MathTest()
        {
            
        }

        public MathTest(int a)
        {
            m_testNumber = a;
        }

        /*public void SetValue(int a)
        {
            value = a;
        }

        public int GetValue()
        {
            return value; 
        }*/

        public static double GetArea(ref Dimensions para)
        {
            return para.Length * para.Width;
        }

        public int GetSquare()
        {
            return m_testNumber * m_testNumber;
        }

        public static int GetSquareOf(int para)
        {
            return para * para;
        }

        public static double GetPi()
        {
            return 3.1415926;
        }
    }
}