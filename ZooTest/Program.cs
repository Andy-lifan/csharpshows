using System;
using System.Collections.Generic;

namespace ZooTest
{
    interface Ivoice
    {
        void voice();    
    }

    class VoiceAll
    {
        List<Ivoice> vthings  = new List<Ivoice>();

        public VoiceAll()
        {
            vthings.Add(new Dog());
            vthings.Add(new Cat());
            vthings.Add(new Fish());
        }

        public void Voiceall()
        {
            foreach (var vthing in vthings)
            {
                vthing.voice();
            }

        }

    }
    public class Animal
    {
        public Animal() { }
        public void voice()
        {
            Console.WriteLine("make some voice..");
        }
    }

    public class Bird
    {
        public String color = "Gray Color";    // Color
        public String skin = "Feather";    // Feather
    }

    public class Dog : Animal, Ivoice
    {
        public Dog() { }
        public void voice()
        {
            Console.WriteLine("woof...");
        }
    }

    public class Fish : Animal, Ivoice
    {
    public Fish() { }
        public void voice()
        {
            Console.WriteLine("Lala...");
        }
    }

    public class Cat : Animal, Ivoice
    {     //inherit from other class
    public Cat() { }
    //public void voice()
    //{
    //    Console.WriteLine("nya...");
    //}
    }

    public class Pigeon : Bird
    {
        //public static void main(String[] args)
        //{
        //    Pigeon pigeon = new Pigeon();
        //    Console.WriteLine(pigeon.color);
        //}
    }



class Program
    {
        static void Main(string[] args)
        {
            VoiceAll voiceall = new VoiceAll();
            voiceall.Voiceall();

            //Dog dog = new Dog();
            //dog.voice();

            //Cat cat = new Cat();
            //cat.voice();

            //Fish fish = new Fish();
            //fish.voice();

            Pigeon pigeon = new Pigeon();
            Console.WriteLine("Pigeon's color is: {0}, Pigeon's skin is: {1}",pigeon.color,pigeon.skin);
      
        }
 

    }

}