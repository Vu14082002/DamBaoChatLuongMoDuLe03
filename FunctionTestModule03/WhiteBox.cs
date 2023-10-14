using System.Text.RegularExpressions;

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


        public bool IsLeapYear(ushort year)
        {
            if (year > 10000 || year < 1000)
                return false;
            else
                if (year % 100 == 0)
                    if (year % 400 == 0)
                        return true;
                    else
                        return false;
                else if (year % 4 == 0)
                    return true;
            else
                return false;
        }

        public bool PasswordCheck(string pass)
        {
            if (pass.Length >= 6)
                if (pass.Length <= 10)
                    if (Regex.IsMatch(pass, @"\d+"))
                        return true;
            return false;
        }

        public Boolean IsValidDate(short Year, Byte Month, Byte Day)
        {
            if (Month >= 1 && Month <= 12)
                if (Day >= 1)
                    if (Day <= DaysInMonth((ushort)Year, Month))
                        return true;
            return false;
        }

        public bool EmailCheck(string email)
        {
            if (Regex.IsMatch(email, @"\."))
            {
                if (Regex.IsMatch(email, @"\.\."))
                    return false;
                else
                    if (Regex.IsMatch(email, @"@"))
                {
                    if (Regex.IsMatch(email, @"(@\.|\.@|@@)"))
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }
            else 
                return false;
        }

        public short BodyCheck(short height,Int32 weight)
        {
            if (height <= 0)
                return -1;
            else
                if (weight <= 0)
                    return -1;
                else
                    {
                        float scale = weight * 1000 / (height * height);
                        if (scale < 18) return 2;
                        else
                        {
                            if (scale > 20) return 1;
                            else return 0;
                        }
                    }
        }

        public int IsInString (char tmp, string str)
        {
            int pos = 32767;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == tmp)
                {

                    pos = i;
                    break;
                }
            return pos;
        }

        public long HexToDec(string hexaString)
        {
            int c;
            long hexnum, nhex;
            hexnum = nhex = 0;
            int i = 0;
            while (i < hexaString.Length)
            {
                c = hexaString[i++];
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - '0');
                        break;
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - 'a' + 0xa);
                        break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - 'A' + 0xA);
                        break;
                    default:
                        break;
                }
            }
            return hexnum;
        }

    }
}