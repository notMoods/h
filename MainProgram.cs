using System;
using System.Text;
using Structures;
using Roo;

namespace styla
{
    public static partial class Tests{
        static void Main()
        {
            Console.WriteLine(ToText(Multiplier((x) => x * 3, g)));           //passing expression lambda to Kapow func param
            Console.WriteLine(ToText(Multiplier((x) => {return x * x;}, g))); //passing statement lambda to Kapow func param
            

            Kapow h = TimesFourPlusOne;
            Kapow u = MinusOne;

            Console.WriteLine(ToText(Multiplier(h, g)));                      //passing delegate variable directly
            Console.WriteLine(ToText(Multiplier(MinusOne, g)));               //passing function directly

            Func<int, int> y = x => MinusOne(x);
            Func<int, int> mn = TimesFourPlusOne;
            Func<int, int> l = x => h(x);
            

            Kapow t = delegate(int g) {return g * 6;};

            Console.WriteLine(ToText(Multiplier(t, g)));                      //calls t which was defined with an anonymous function

            Kapow multi = u + h;                                              //multicast delegate, it doesnt combine them when called it does it
                                                                              //sequentially so in the end the last delegate added is the end

            Kapow trueMulti = x =>y(mn(x));                                   //here mn is called in y

            Console.WriteLine(ToText(Multiplier(multi, g)));
            Console.WriteLine(ToText(Multiplier(trueMulti, g)));

             
            /*Output
            {3, 6, 9, 12, 15}
            {1, 4, 9, 16, 25}
            {5, 9, 13, 17, 21}
            {0, 1, 2, 3, 4}
            {6, 12, 18, 24, 30}
            */

            var head = new Node(1);
            //head.left = new Node(2);
            //head.right = new Node(3);
            //head.left.left = new Node(4);
            //head.left.right = new Node(5);
            //head.right.left = new Node(6);
            //head.right.right = new Node(7);












        }
    }
        
    
}
