using System;

namespace Inheritace
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Id = 1;
            dog.Name = "IronMan";
            dog.Age = "5 Month";
            dog.Weight = 25.65;
            dog.Goes();
            
            Cat cat = new Cat();
            cat.Id = 1;
            cat.Name = "Gikky";
            cat.Age = "1 year";
            cat.Weight = 5.5;
            cat.Gose();

            var animal = new Animal();
            animal.Goes();

            ScottishFold scottish = new ScottishFold();
            scottish.Goes();

            Senbernar senbernar = new Senbernar();
            senbernar.Goes();
            
        }
    }
}
