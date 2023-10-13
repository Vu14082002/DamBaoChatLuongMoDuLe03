namespace FunctionTestModule03
{
    public class WhiteBox
    {
        public string Triangle(int a, int b, int c)
        {
            int match = 0;

            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;

            if (match == 0)
            {
                if ((a + b) <= c)
                {
                    return "Not a Triangle";
                }
                else if ((b + c) <= a)
                {
                    return "Not a Triangle";
                }
                else if ((a + c) <= b)
                {
                    return "Not a Triangle";
                }
                else
                {
                    return "Triangle is Scalene";
                }
            }
            else if (match == 1)
            {
                if ((a + c) <= b)
                {
                    return "Not a Triangle";
                }
                else
                {
                    return "Triangle is Isosceles";
                }
            }
            else if (match == 2)
            {
                if ((a + c) <= b)
                {
                    return "Not a Triangle";
                }
                else
                {
                    return "Triangle is Isosceles";
                }
            }
            else if (match == 3)
            {
                if ((b + c) <= a)
                {
                    return "Not a Triangle";
                }
                else
                {
                    return "Triangle is Isosceles";
                }
            }
            else
            {
                return "Triangle is Equilateral";
            }
        }

        public double Average(double Sum, double Count)
        {
            if (Count == 1) 
                return Sum; 
            else if (Count > 0) 
                return Sum / Count;
         else return 0;
        }
        public byte DaysInMonth(ushort Year, byte Month)
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
               return 31;
            }
            else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                return 30;
            }
            else if (Month == 2)
            {
                if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }else
            {
                return 0;
            }
        }



    }
}