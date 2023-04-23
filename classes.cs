namespace Roo{

    class A{
        public virtual void Run() {Console.WriteLine("this is A method");}

        public void Hoo() {Console.WriteLine("a's hoo");}
    }

    class B : A{
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
}