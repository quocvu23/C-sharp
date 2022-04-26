using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diemdanh
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.eat();
            cat.makeSound();
            cat.run();
            Bird bird = new Bird();
            bird.eat();
            bird.makeSound();
            bird.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Thuc an");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("Meo chay nhanh");

        }
        public override void eat()
        {
            Console.WriteLine("Meo an ca ngon ngon");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo keu meowwwwwwwww meowwwwwwww");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Chim bay cao tren troi");

        }
        public override void eat()
        {
            Console.WriteLine("Chim an sau xanh la");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chim hot liu lo");
        }
    }
}

