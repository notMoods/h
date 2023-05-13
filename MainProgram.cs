using System;
using System.Text;
using Structures;
using Roo;
using eventName;

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


            Node head = NodeGenerator(7);

            while(true)
            {
                Console.WriteLine(ToText(TreeTraversal(head)));

                Console.WriteLine("Press X to exit");

                if(Console.ReadLine() == "X") break;
            }

            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += hhh.c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }
    }  
}
