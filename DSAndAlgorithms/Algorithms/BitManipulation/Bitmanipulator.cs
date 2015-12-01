using System;

namespace DSAndAlgorithms.Algorithms.BitManipulation
{
    internal class Bitmanipulator
    {
        /// <summary>
        /// Add two integers without using any binary operators
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Sum</returns>
        public static int Add(int x, int y)
        {
            // Iterate till there is no carry  
            while (y != 0)
            {
                // carry now contains common set bits of x and y
                int carry = x & y;

                // Sum of bits of x and y where at least one of the bits is not set
                x = x ^ y;

                // Carry is shifted by one so that adding it to x gives the required sum
                y = carry << 1;
            }
            return x;
        }

        public void BitManipulation()
        {
            int a = 32;
            int b = 78;
            int shift = 5;
            int ALLBITS = Convert.ToInt32("11111111111111111111111111111111", 2); ;
            /*
             * NOTE:I am using 8 bits to explain the concept, 
             * .Net int would use 32 bit integers but the concept would remain the same 
             */


            /*Bitwise Compliment
             * 1  = 00000001
             * ~1 = 11111110 (In 2's compliment representation this is -2) 
             * ------Explanation of -2:---------
             *  2 = 00000010
             * -2 = 11111101 +1 = 11111110
             */
            Console.WriteLine(~1);


            /*Bitwise And 
             * 1  = 00000001
             * 2  = 00000010
             * 1&2= 00000000 = 0
             */
            Console.WriteLine(1 & 2);


            //Bitwise Or
            //1  = 00000001
            //2  = 00000010
            //1|2= 00000011 = 3
            Console.WriteLine(1 | 2);


            /*
               Here's how XOR works:
             * If both operands have a bit set i.e. 1, the result does not have that bit set.
             * If neither has a bit set, the result still does not have the bit set. 
             * But if one has the bit set, the result is set.
             * XOR is used for checking bit parity
             */


            //Bitwise XOR
            //1  = 00000001
            //2  = 00000010
            //1&2= 00000011 = 3
            Console.WriteLine(1 ^ 2);


            //Bitwise Right Shift. Shift operators are used for multiplying and division.
            //1   = 00000001
            //1>>2= 00000000 = 0
            Console.WriteLine(1 >> 2);


            //Bitwise Left Shift 
            //1   = 00000001
            //1<<2= 00000100 = 4
            Console.WriteLine(1 << 2);

            // Set Subtraction
            Console.WriteLine(a & ~b);

            // Set Negation
            Console.WriteLine(ALLBITS ^ a);

            // Set Bit
            a |= 1 << shift; 

            // Clear Bit
            a &= ~(1 << shift);

            // Bitwise OR operator is used for adding a flag to the Enum
            States states = States.AL | States.TN;

            CheckStates(states);

            states |= States.MN;

            CheckStates(states);

            states |= States.WI;

            CheckStates(states);

            // Bitwise ^ operator is used for removing a flag from the Enum
            states ^= States.AL;

            CheckStates(states);





        }

        private static void CheckStates(States states)
        {
            switch (states)
            {
                case States.AL:
                {
                    Console.WriteLine("AL");
                }
                    break;
                case States.AL | States.TN:
                {
                    Console.WriteLine("AL, TN");
                }
                    break;

                case States.AL | States.MN:
                {
                    Console.WriteLine("AL, MN");
                }
                    break;
            }
        }

        private static string GetIntBinaryString(int n)
        {
            // This procedure checks by anding the number n with another number which has only 1 digit set and rest all are not set,
            //this is done by left shifting '1'.
            var b = new char[32];
            int pos = 31;
            int i = 0;


            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }

        public static bool AreUniqueChars(String str)
        {
            var chars = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (chars[val]) return false;
                chars[val] = true;
            }
            return true;
        }

        /// <summary>
        /// This will only work when a-z (26). If A-Z also, then maybe we can use long (64)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool AreUniqueCharsUsingBitManipulation(String str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0) return false;
                checker |= (1 << val);
            }
            return true;
        }

        public static bool AreIntegersOfOppositeSigns(int a, int b)
        {
            if (a > 0 && b < 0)
            {
                return true;
            }

            if (a < 0 && b > 0)
            {
                return true;
            }

            return false;
        }

        public static bool AreIntegersOfOppositeSignsUsingBitManipulation(int a, int b)
        {
            return (a ^ b) < 0;
        }
    }

    /*
     The flags attribute can be used whenever the enumerable represents a collection of flags rather than a single value. 
     * Such collections can then be manipulated using Bitwise operators
     */

    [Flags]
    public enum States : long
    {
        None = 0,
        AL = 1L << 0,
        MN = 1L << 1,
        TN = 1L << 2,
        WI = 1L << 3
    }
}