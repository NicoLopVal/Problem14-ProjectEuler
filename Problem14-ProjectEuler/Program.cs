using System;

namespace Problem14_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int chainNumber = 0;
            int[] maxChain = new int[2] { 0, 0 };

            for(double i = 2; i < 1000000; i++)
            {
                chainNumber = 1;
                double currentValue = i;

                while (true)
                {
                    if(currentValue == 1)
                    {
                        chainNumber++;
                        break;
                    }
                    if(currentValue% 2 == 0)
                    {
                        currentValue = currentValue / 2;
                        chainNumber++;
                    }
                    else
                    {
                        currentValue = (currentValue * 3) + 1;
                    }
                }
                if(chainNumber > maxChain[0])
                {
                    maxChain[0] = chainNumber;
                    maxChain[1] = (int)i;
                }
            }

            Console.WriteLine("The starting number that generates more chain number is: " + maxChain[1] + " with a chain of " + maxChain[0]);
        }
    }
}
