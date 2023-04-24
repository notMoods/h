using Structures;
using System.Text;

namespace styla{

    public delegate int Kapow(int h);

    public static partial class Tests
    {
        //source array for calculations
        public static int[] g = {1, 2, 3, 4, 5};
        
        //function that takes an int and returns it minus 1
        public static int MinusOne(int k) => k - 1;

        
        public static int TimesFourPlusOne(int h)
        {
            return (h * 4) + 1;
        }

        public static int[] Multiplier(Kapow func, int[] h)
        {
            var result = new int[h.Length];

            for(int a = 0; a < result.Length; a++)
            {
                result[a] = func(h[a]);
            }
            return result;
        }

        public static string ToText(IEnumerable<int> k)
        {
            var res = new StringBuilder("{");
            foreach(int h in k)
            {
                res.Append($"{h}, ");
            }
            res.Remove(res.Length - 2, 2);
            res.Append("}");
            return res.ToString();
        }

        //extension method employing generics
        public static IEnumerable<TRes> CountIf<TSource, TRes>(this IEnumerable<TSource> source, Func<TSource, TRes> query)
        {
            foreach(var t in source)
            {
                yield return query(t);
            }

        }
       

        public static Node NodeGenerator(int h)
        {
            Node head = new Node(1);
            int start = 2;

            var hoo = new Queue<Node>();
            hoo.Enqueue(head);

            while(true)
            {
                Node foo = hoo.Dequeue();
                
                foo.left = new Node(start++);
                hoo.Enqueue(foo.left);
                if(start > h) break;

                foo.right = new Node(start++);
                hoo.Enqueue(foo.right);
                if(start > h) break;
            }

            return head;
        }

        public static List<int> TreeTraversal(Node head)
        {
            int input;
            do{
                Console.WriteLine("Pick a traversal: " + 
                "\n1 for PreOrder, 2 for InOrder, 3 for PostOrder");
            }while(!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 3);


            var res = new List<int>();
            switch(input)
            {
                case 1:
                  res = PreOrder(head, new List<int>());
                  break;
                case 2:
                  res = InOrder(head, new List<int>());
                  break;
                case 3:
                  res = PostOrder(head, new List<int>());
                  break;    
            }
            return res;
        }

        private static List<int> PostOrder(Node? head, List<int> list)
        {
            if(head == null) return list;

            PostOrder(head.left, list);
            PostOrder(head.right, list);
            list.Add(head.value);

            return list;
        }

        private static List<int> InOrder(Node? head, List<int> list)
        {
            if(head == null) return list;

            InOrder(head.left, list);
            list.Add(head.value);
            InOrder(head.right, list);

            return list;
        }

        private static List<int> PreOrder(Node? head, List<int> list)
        {
            if(head == null) return list;

            list.Add(head.value);
            PreOrder(head.left, list);
            PreOrder(head.right, list);

            return list;
        }
    }
}