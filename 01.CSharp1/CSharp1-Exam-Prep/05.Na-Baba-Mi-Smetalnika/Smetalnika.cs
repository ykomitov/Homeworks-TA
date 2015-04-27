using System;
using System.Collections.Generic;
using System.IO; //<------------------ must be there to get input from txt file
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //get input from text file
        //StreamReader reader = new StreamReader("..\\..\\SampleInput.txt");
        //Console.SetIn(reader);

        //get input from the console
        int width = int.Parse(Console.ReadLine());
        int a1 = int.Parse(Console.ReadLine());
        int a2 = int.Parse(Console.ReadLine());
        int a3 = int.Parse(Console.ReadLine());
        int a4 = int.Parse(Console.ReadLine());
        int a5 = int.Parse(Console.ReadLine());
        int a6 = int.Parse(Console.ReadLine());
        int a7 = int.Parse(Console.ReadLine());
        int a8 = int.Parse(Console.ReadLine());

        //convert the input to strings containing binary code
        string a1string = Convert.ToString(a1, 2).PadLeft(32, '0').Substring(32 - width);
        string a2string = Convert.ToString(a2, 2).PadLeft(32, '0').Substring(32 - width);
        string a3string = Convert.ToString(a3, 2).PadLeft(32, '0').Substring(32 - width);
        string a4string = Convert.ToString(a4, 2).PadLeft(32, '0').Substring(32 - width);
        string a5string = Convert.ToString(a5, 2).PadLeft(32, '0').Substring(32 - width);
        string a6string = Convert.ToString(a6, 2).PadLeft(32, '0').Substring(32 - width);
        string a7string = Convert.ToString(a7, 2).PadLeft(32, '0').Substring(32 - width);
        string a8string = Convert.ToString(a8, 2).PadLeft(32, '0').Substring(32 - width);


        //initialize the 8 rows in arrays
        char[] line1 = new char[width];
        char[] line2 = new char[width];
        char[] line3 = new char[width];
        char[] line4 = new char[width];
        char[] line5 = new char[width];
        char[] line6 = new char[width];
        char[] line7 = new char[width];
        char[] line8 = new char[width];

        //fill the arrays with the 8 numbers from the input
        line1 = a1string.ToCharArray();
        line2 = a2string.ToCharArray();
        line3 = a3string.ToCharArray();
        line4 = a4string.ToCharArray();
        line5 = a5string.ToCharArray();
        line6 = a6string.ToCharArray();
        line7 = a7string.ToCharArray();
        line8 = a8string.ToCharArray();

        string command = "";

        do
        {
            command = Console.ReadLine();
            //==============================================>               RESET
            if (command == "reset")
            {
                int count1 = 0;

                for (int i = 0; i < line1.Length; i++)
                {
                    if (line1[i] == 49)
                    {
                        count1++;
                    }
                }
                for (int i = 0; i < line1.Length; i++)
                {
                    if (i < count1)
                    {
                        line1[i] = (char)49;
                    }
                    else
                    {
                        line1[i] = (char)48;
                    }
                }
                int count2 = 0;

                for (int i = 0; i < line2.Length; i++)
                {
                    if (line2[i] == 49)
                    {
                        count2++;
                    }
                }
                for (int i = 0; i < line2.Length; i++)
                {
                    if (i < count2)
                    {
                        line2[i] = (char)49;
                    }
                    else
                    {
                        line2[i] = (char)48;
                    }
                }
                int count3 = 0;

                for (int i = 0; i < line3.Length; i++)
                {
                    if (line3[i] == 49)
                    {
                        count3++;
                    }
                }
                for (int i = 0; i < line3.Length; i++)
                {
                    if (i < count3)
                    {
                        line3[i] = (char)49;
                    }
                    else
                    {
                        line3[i] = (char)48;
                    }
                }
                int count4 = 0;

                for (int i = 0; i < line4.Length; i++)
                {
                    if (line4[i] == 49)
                    {
                        count4++;
                    }
                }
                for (int i = 0; i < line4.Length; i++)
                {
                    if (i < count4)
                    {
                        line4[i] = (char)49;
                    }
                    else
                    {
                        line4[i] = (char)48;
                    }
                }
                int count5 = 0;

                for (int i = 0; i < line5.Length; i++)
                {
                    if (line5[i] == 49)
                    {
                        count5++;
                    }
                }
                for (int i = 0; i < line5.Length; i++)
                {
                    if (i < count5)
                    {
                        line5[i] = (char)49;
                    }
                    else
                    {
                        line5[i] = (char)48;
                    }
                }
                int count6 = 0;

                for (int i = 0; i < line6.Length; i++)
                {
                    if (line6[i] == 49)
                    {
                        count6++;
                    }
                }
                for (int i = 0; i < line6.Length; i++)
                {
                    if (i < count6)
                    {
                        line6[i] = (char)49;
                    }
                    else
                    {
                        line6[i] = (char)48;
                    }
                }
                int count7 = 0;

                for (int i = 0; i < line7.Length; i++)
                {
                    if (line7[i] == 49)
                    {
                        count7++;
                    }
                }
                for (int i = 0; i < line7.Length; i++)
                {
                    if (i < count7)
                    {
                        line7[i] = (char)49;
                    }
                    else
                    {
                        line7[i] = (char)48;
                    }
                }
                int count8 = 0;

                for (int i = 0; i < line8.Length; i++)
                {
                    if (line8[i] == 49)
                    {
                        count8++;
                    }
                }
                for (int i = 0; i < line8.Length; i++)
                {
                    if (i < count8)
                    {
                        line8[i] = (char)49;
                    }
                    else
                    {
                        line8[i] = (char)48;
                    }
                }
            }
            //==============================================>               STOP
            else if (command == "stop")
            {
                //convert the arrays to string containing binary number
                string line1Result = new string(line1);
                string line2Result = new string(line2);
                string line3Result = new string(line3);
                string line4Result = new string(line4);
                string line5Result = new string(line5);
                string line6Result = new string(line6);
                string line7Result = new string(line7);
                string line8Result = new string(line8);

                //convert binary string to integer
                int line1ResultInt = Convert.ToInt32(line1Result, 2);
                int line2ResultInt = Convert.ToInt32(line2Result, 2);
                int line3ResultInt = Convert.ToInt32(line3Result, 2);
                int line4ResultInt = Convert.ToInt32(line4Result, 2);
                int line5ResultInt = Convert.ToInt32(line5Result, 2);
                int line6ResultInt = Convert.ToInt32(line6Result, 2);
                int line7ResultInt = Convert.ToInt32(line7Result, 2);
                int line8ResultInt = Convert.ToInt32(line8Result, 2);
                BigInteger finalSum = (line1ResultInt +
                                            line2ResultInt +
                                            line3ResultInt +
                                            line4ResultInt +
                                            line5ResultInt +
                                            line6ResultInt +
                                            line7ResultInt +
                                            line8ResultInt);
                int columnsCount = 0;

                for (int i = 0; i < line1.Length; i++)
                {
                    if (line1[i] == 48 &&
                        line2[i] == 48 &&
                        line3[i] == 48 &&
                        line4[i] == 48 &&
                        line5[i] == 48 &&
                        line6[i] == 48 &&
                        line7[i] == 48 &&
                        line8[i] == 48)
                    {
                        columnsCount++;
                    }
                }
                BigInteger finalResult = columnsCount * finalSum;
                Console.WriteLine(finalResult);
            }
            //==============================================>               RIGHT
            else if (command == "right")
            {
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());

                //=====================================         check if position is below zero or above width of smetalo
                if (position < 0)
                {
                    position = 0;
                }
                else if (position > width)
                {
                    position = width;
                }
                //=====================================

                int countOnes = 0;

                switch (line)
                {
                    case 0:
                        countOnes = 0;
                        for (int i = position; i < line1.Length; i++)
                        {
                            if (line1[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line1.Length - 1; i >= line1.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line1[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line1[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 1:
                        countOnes = 0;
                        for (int i = position; i < line2.Length; i++)
                        {
                            if (line2[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line2.Length - 1; i >= line2.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line2[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line2[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 2:
                        countOnes = 0;
                        for (int i = position; i < line3.Length; i++)
                        {
                            if (line3[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line3.Length - 1; i >= line3.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line3[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line3[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 3:
                        countOnes = 0;
                        for (int i = position; i < line4.Length; i++)
                        {
                            if (line4[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line4.Length - 1; i >= line4.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line4[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line4[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 4:
                        countOnes = 0;
                        for (int i = position; i < line5.Length; i++)
                        {
                            if (line5[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line5.Length - 1; i >= line5.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line5[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line5[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 5:
                        countOnes = 0;
                        for (int i = position; i < line6.Length; i++)
                        {
                            if (line6[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line6.Length - 1; i >= line6.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line6[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line6[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 6:
                        countOnes = 0;
                        for (int i = position; i < line7.Length; i++)
                        {
                            if (line7[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line7.Length - 1; i >= line7.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line7[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line7[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 7:
                        countOnes = 0;
                        for (int i = position; i < line8.Length; i++)
                        {
                            if (line8[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = line8.Length - 1; i >= line8.Length - position; i--)
                        {
                            if (countOnes > 0)
                            {
                                line8[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line8[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    default:
                        break;
                }

            }
            //=======================================                LEFT
            else if (command == "left")
            {
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());

                
                //=====================================         check if position is below zero or above width of smetalo
                if (position < 0)
                {
                    position = 0;
                }
                else if (position > width)
                {
                    position = width;
                }
                //=====================================

                int countOnes = 0;

                switch (line)
                {
                    case 0:
                        countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line1[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line1[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line1[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 1:
                        countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line2[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line2[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line2[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 2:
                        countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line3[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line3[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line3[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 3:
                          countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line4[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line4[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line4[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 4:
                          countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line5[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line5[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line5[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 5:
                           countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line6[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line6[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line6[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 6:
                         countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line7[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line7[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line7[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    case 7:
                         countOnes = 0;
                        for (int i = position; i >= 0; i--)
                        {
                            if (line8[i] == 49)
                            {
                                countOnes++;
                            }
                        }
                        for (int i = 0; i < position; i++)
                        {
                            if (countOnes > 0)
                            {
                                line8[i] = (char)49;
                                countOnes--;
                            }
                            else if (countOnes <= 0)
                            {
                                line8[i] = (char)48;
                                countOnes--;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

        } while (command != "stop");
    }
}
