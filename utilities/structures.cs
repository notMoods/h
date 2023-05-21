using System;

namespace Structures
{
    public class Node
    {
        public int value;
        public Node? left;
        public Node? right;

        public Node(int h, Node? l = null, Node? r = null)
        {
            value = h;
            left = l;
            right = r;
        }
    }
}