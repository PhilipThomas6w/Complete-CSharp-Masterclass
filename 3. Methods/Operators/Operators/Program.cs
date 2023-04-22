using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c;

            // unary operators 
            c = -a;
            Console.WriteLine("c = {0}", c); // The {0} is a placeholder for the value of c.
            Console.ReadKey(); // This is to keep the console window open.

            // increment operator
            int d = 10;
            int e = d++; // The value of d is assigned to e, then d is incremented.
            Console.WriteLine("d = {0}", d);
            Console.ReadKey();

            // decrement operator
            int f = 10;
            int g = f--; // The value of f is assigned to g, then f is decremented.
            Console.WriteLine("f = {0}", f);
            Console.ReadKey();

            // boolean operator
            bool result = a > b;
            Console.WriteLine("result = {0}", result);
            Console.ReadKey();

            // ternary operator (also called conditional operator)
            int h = (a > b) ? a : b; // If a > b, then h = a, else h = b.
            Console.WriteLine("d = {0}", d);
            Console.ReadKey();

            // bitwise operator
            int i = 10;
            int j = 20;
            int k = i & j; // Bitwise AND
            Console.WriteLine("g = {0}", g);
            Console.ReadKey();

            // assignment operator
            int l = 10;
            int m = 20;
            l += m; // l = l + m
            Console.WriteLine("l = {0}", l);

            // equality operator
            int n = 10;
            int o = 20;
            bool p = (n == o); // If n is equal to o, then p = true, otherwise p = false.
            Console.WriteLine("p = {0}", p);
            Console.ReadKey();

            // relational operator
            int q = 10; 
            int r = 20;
            bool s = (q > r); // If q is greater than r, then s = true, otherwise s = false.
            Console.WriteLine("s = {0}", s);
            Console.ReadKey();
            
            // shift operator
            int t = 10; // 0000 1010
            int u = t << 2; // 0010 1000 i.e., shifts the bits of r to the left by 2.
            Console.WriteLine("u = {0}", u);
            Console.ReadKey();

            // sizeof operator
            int v = sizeof(int); // Returns the size of an integer.
            Console.WriteLine("v = {0}", v);
            Console.ReadKey();
            
            // typeof operator
            Type w = typeof(int); // Returns the type of an integer.
            Console.WriteLine("w = {0}", w);
            Console.ReadKey();
            
            // multiplication operator
            int x = 10;
            int y = 20;
            int z = x * y;
            Console.WriteLine("z = {0}", z);
            Console.ReadKey();

            // division operator
            int aa = 10;
            int ab = 20;
            int ac = aa / ab;
            Console.WriteLine("ac = {0}", ac);
            Console.ReadKey();

            // modulus operator (also called remainder operator)
            int ad = 10;
            int ae = 20;
            int af = ad % ae; // Returns the remainder of ad / ae.
            Console.WriteLine("af = {0}", af);
            Console.ReadKey();

            // addition operator
            int ag = 10;
            int ah = 20;
            int ai = ag + ah;
            Console.WriteLine("ai = {0}", ai);
            Console.ReadKey();

            // subtraction operator
            int aj = 10;
            int ak = 20;
            int al = aj - ak;
            Console.WriteLine("al = {0}", al);

            // conditional AND operator
            int am = 10;
            int an = 20;
            bool ao = (am > 5) && (an > 5); // If am > 5 AND an > 5, then ao = true, else ao = false.
            Console.WriteLine("ao = {0}", ao);
            Console.ReadKey();

            // conditional OR operator
            int ap = 10;
            int aq = 20;
            bool ar = (ap > 5) || (aq > 5); // If ap > 5 OR aq > 5, then ar = true, else ar = false.
            Console.WriteLine("ar = {0}", ar);
            Console.ReadKey();

            // conditional NOT operator
            int at = 10;
            bool au = !(at > 5); // If at > 5, then au = false, else au = true.
            Console.WriteLine("au = {0}", au);
            Console.ReadKey();

            // exclusive OR operator
            int av = 10;
            int aw = 20;
            bool ax = (av > 5) ^ (aw > 5); // If av > 5 XOR aw > 5, then ax = true, else ax = false.
            Console.WriteLine("ax = {0}", ax);
            Console.ReadKey();

         




















        }
    }
}
