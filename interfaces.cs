namespace InterfaceTesting
{
    interface IEater{
        int Eat<T>(IEaten<T> noot){
            noot.Eaten(this);
            return noot.calories;
        }

        bool CheckIfMeal(object o)
        {
            return o.GetType().GetInterfaces()
                   .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEaten<>));
        }

        int strength{get; set;}
    }

    interface IEaten<T>{
        int calories{get; set;}

        void Eaten(IEater predator)
        {
            Console.WriteLine($"Eaten by {predator.GetType().Name}");
        }
    }
}