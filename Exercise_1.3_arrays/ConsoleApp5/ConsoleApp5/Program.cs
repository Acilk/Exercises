using System;

namespace binaryCalc;

class Program
{
    static void Main(string[] args)
    {
        int n = 0, n1 = 0, n2 = 0, na1 = 0, na2 = 0, sign = 0, sign1 = 0, sign2 = 0, bitSign = 0;

        //First Number
        int number = GetNumber();
        n1 = number;
        na1 = Math.Abs(n1);
        n = na1;
        int[] binaryNumber1 = GetBinary(n);
        sign1 = GetZM(number, sign);
        int[] zu1_1 = Zu1(binaryNumber1, number);
        int[] zu2_1 = Zu2(binaryNumber1, number);

        //Second Number
        number = GetNumber();
        n2 = number;
        na2 = Math.Abs(n2);
        n = na2;
        int[] binaryNumber2 = GetBinary(n);
        sign2 = GetZM(number, sign);
        int[] zu1_2 = Zu1(binaryNumber2, number);
        int[] zu2_2 = Zu2(binaryNumber2, number);

        int[] resultZU2 = addZU(zu2_1 , zu2_2);
        int[] resultZU1 = addZU(zu1_1, zu1_2);
        int[] resultZM  = addZM(sign1, sign2, binaryNumber1, binaryNumber2);

        int[] resultQA = BoothMethod(zu2_1, zu2_2, n1);


        GetResult(n1, n2, na1, na2, n, sign1, sign2, bitSign, binaryNumber1, binaryNumber2, zu1_1, zu1_2, zu2_1, zu2_2, resultZU1, resultZU2, resultZM, resultQA);
    }

    static int GetNumber()
    {
        int number;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer, please, try again! ");
        }
        return number;
    } 

    static int[] GetBinary(int n)
    {
        int[] binaryNumber = new int[32];
        

        for (int i = 0; i < 32; i++)
        {
            binaryNumber[i] = n % 2;
            n /= 2;
        }

        return binaryNumber;
    }

    static int GetZM(int number, int sign)
    {

        if (number >= 0)
        {
            sign = 0;
        }
        else if (number < 0)
        {
            sign = 1;
        }

        return sign;
    }

    static int[] Zu1(int[] binaryNumber, int number)
    {
        int[] zu1 = new int[32];

        if (number < 0)
        {
            Array.Copy(binaryNumber, zu1, 32);

            for(int i = 0; i < 32; i++)
            {
                if(zu1[i] == 0)
                {
                    zu1[i] = 1;
                }
                else if(zu1[i] == 1)
                {
                    zu1[i] = 0;
                }
            }
        }
        else
        {
            Array.Copy(binaryNumber, zu1, 32);
        }
        return zu1;
    }

    static int[] Zu2(int[]binaryNumber, int number)
    {
        int[] zu2 = Zu1(binaryNumber, number);

        if(number < 0)
        {

            for(int i = 0; i < 32; i++)
            {
                if(zu2[i] == 0)
                {
                    zu2[i] = 1;
                    break;
                }
                else
                {
                    zu2[i] = 0;
                }
            }
        }
        return zu2;
    }

    static int[] addZU(int[] a, int [] b)
    {
        
        int[] resultZU = new int[32];
        int carry = 0;

        for(int i = 0; i < 32; i++)
        {
            int sum = a[i] + b[i] + carry;
            
            resultZU[i] = sum % 2;
            carry = sum / 2;
        }
        
        return resultZU;
    }

    static int[] subZM(int[] a, int[] b)
    {
        int[] resultZM = new int[32];
        int borrow = 0;

        for (int i = 0; i < 32; i++)
        {
            int diff = a[i] - b[i] + borrow;
            if(diff < 0)
            {
                diff += 2;
                borrow = -1;
            }
            else
            {
                borrow = 0;
            }
            resultZM[i] = diff;

        }
        return resultZM;
    }

    static int[] addZM(int sign1, int sign2, int[] a, int[] b)
    {
        int[] resultZM = new int[32];
        if(sign1 == sign2)
        {
            resultZM = addZU(a, b);
        }
        else if(sign1 != sign2)
        {
            resultZM = subZM(a, b);   
        }

        return resultZM;
    }

    static int[] BoothMethod(int[] M, int[] Q, int n1)
    {
        int n = M.Length;

        int[] A = new int[n];
        int[] minusM = Zu2(M, n1);
        int Q_1 = 0;

        for(int i = 0; i < n; i++)
        {
            if(Q[0] == 1 && Q_1 == 0)
            {
                A = addZU(A, minusM);
            }
            else if(Q[0] == 0 && Q_1 == 1)
            {
                A = addZU(A, M);
            }

            int sign = A[n - 1];
            int oldQ0 = Q[0];
            int oldA0 = A[0];

            for (int j = n-1; j > 0; j--)
            {
                A[j] = A[j - 1];
            }

            A[0] = sign;

            for (int j = n - 1; j > 0; j--)
            {
                Q[j] = Q[j - 1];
            }

            Q[0] = oldA0;

            Q_1 = oldQ0;
        }


        int[] resultQA = new int[2 * n];
      
        for (int i = 0; i < n; i++)
        {
            resultQA[i] = A[i];
        }
            
        for (int i = 0; i < n; i++)
        {
            resultQA[i + n] = Q[i];
        }
            

        return resultQA;
    }

    static void GetResult(int n1, int n2, int na1, int na2, int n, int sign1, int sign2, int bitSign, int[] binaryNumber1, int[] binaryNumber2, int[] zu1_1, int[] zu1_2, int[] zu2_1, int[] zu2_2, int[] resultZU1, int[] resultZU2, int[] resultZM, int[] resultQA)
    {
        Console.WriteLine();
        Console.WriteLine($"{n1} {n2} {na1} {na2} {n}");
        Console.WriteLine();

        Console.Write(sign1 + ".");
        for (int i = 31; i >= 0; i--)
        {
            Console.Write(binaryNumber1[i]);
        }
        Console.WriteLine();

        Console.Write(sign2 + ".");
        for (int i = 31; i >= 0; i--)
        {
            Console.Write(binaryNumber2[i]);
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("ZU1 of first number: ");

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(zu1_1[i]);
        }

        Console.WriteLine();
        Console.Write("ZU1 of second number: ");

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(zu1_2[i]);
        }

        Console.WriteLine();
        Console.Write("ZU2 of first number: ");

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(zu2_1[i]);
        }

        Console.WriteLine();
        Console.Write("ZU2 of second number: ");

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(zu2_2[i]);
        }

        Console.WriteLine();
        Console.Write("Result of adding ZU2 numbers: ");

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(resultZU2[i]);
        }

        Console.WriteLine();
        Console.Write("Result of adding ZU1 numbers: ");

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(resultZU1[i]);
        }

        Console.WriteLine();
        Console.Write("Result of adding ZM numbers: ");

        if(n1 > n2 && n1 > 0)
        {
            Console.Write(sign1 + ".");
        }
        else
        {
            Console.Write(sign2 + ".");
        }

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(resultZM[i]);
        }

        Console.WriteLine();
        Console.Write("Result of Booth Method: ");


        for (int i = 63; i >= 0; i--)
        {
            Console.Write(resultQA[i]);
        }
    }
}
