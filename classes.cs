namespace Roo{

    class A{
        public virtual void Run() {Console.WriteLine("this is A method");}
    }

    class B : A{
        public override void Run()
        {
            Console.WriteLine("this is B method");
        }
    }

    class C : B{
        public override void Run()
        {
            Console.WriteLine("this is C method");
        }
    }
}