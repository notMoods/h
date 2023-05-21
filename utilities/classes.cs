namespace Roo{

    interface IKicker{
        public void Kick(){Console.WriteLine("IKicker's Kick");}
    }

    class A : IKicker{
        public virtual void Run() {Console.WriteLine("this is A method");}

        public void Hoo() {Console.WriteLine("a's hoo");}
       public void Kick(){Console.WriteLine("A's inner kick");}
    }

    class B : A, IKicker{
        public override void Run()
        {
            Console.WriteLine("this is B method");
        }

        public void Foo() {Console.WriteLine("b's foo");}
    }

    class C : B{
        public override void Run()
        {
            Console.WriteLine("this is C method");
        }

        public new void Foo() {Console.WriteLine("C new in this bih");}
    }

    class Testsg{
        static void Main(){
            IKicker h = new A();
            h.Kick();

            A gb = new A();
            gb.Kick();

            IKicker j = gb;
            j.Kick();

            IEnumerable<object> loo = new List<object>();
            IEnumerable<object> looh = new List<List<int>>();

            IList<IList<int>> glow = new List<IList<int>>();

            
        }
    }
}