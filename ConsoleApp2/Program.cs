using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {



            /*
           Console.Title = "skynet";      //we have changed the title of console screen
           Console.ForegroundColor = ConsoleColor.Green;   //the word will change its color
           Console.WindowHeight = 40;            //it is gonna change the height of the console
           Console.WindowWidth = 100;            //it is gonna change the width of the console 
           Console.WriteLine("Hello World");
           Console.WriteLine("hey every body");
           */



            /*
               Console.WriteLine("helllo world");
               Console.ReadKey();             //press any key....you can print enter to make the next step without adding anything
               Console.WriteLine("helllo world");
               */


            /*
            for(int i=0;i<=10;i++)
            {
                double result = Math.Pow(2, i);     //we make it double becuase we need more memory
                Console.WriteLine(result);
            }
            */


            /*
            start:
            int num;
            int num2;
            Console.WriteLine("enter two numbers: ");
            num = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            goto start;
            */

            /*
            Random number = new Random();
            int num1 = number.Next(1,11);   //this is the function that returns a non-negative numbers that is of course random and that is an integer
             int num2 = number.Next(1, 11);
            Console.WriteLine("what is " + num1 + " times " + num2);
            int ansewr = Convert.ToInt32(Console.ReadLine());
            if (ansewr == num1 + num2)
                Console.WriteLine("well done");
            else
            {
                int res = number.Next(1,4);
                switch (res) { 
                    case 1:
                        Console.WriteLine("bad choice");
                        break;
                    case 2:
                        Console.WriteLine("try more");
                        break;
                    default:
                        Console.WriteLine("not correst");
                        break;
                }
            }
            */

            /*
            Random number = new Random();
            int num1 = number.Next(1, 11);   
            int num2 = number.Next(1, 11);
            Console.WriteLine("what is " + num1 + " times " + num2);
            int ansewr = Convert.ToInt32(Console.ReadLine());
            if (ansewr == num1 + num2)
            { 
                int res = number.Next(1, 4);
                switch (res)
                { 
                    case 1:
                        Console.WriteLine("correct, well done");
                        break;
                    case 2:
                        Console.WriteLine("correct,nice answer");
                        break;
                    default:
                        Console.WriteLine("correst,this is right");
                        break;
                }
            }
            else
            {
                int diff = Math.Abs(ansewr - (num1 + num2));
                if (diff == 1)
                    Console.WriteLine("so close");
                else if (diff <= 10)
                    Console.WriteLine("you can do better than that");
                else
                    Console.WriteLine("you are not even close");
            }
            */

            /*
            Random numberGen = new Random();
            int numberofattempts = 0;
            int attempts = 0;
            while (attempts!=6)
            {
                attempts = numberGen.Next(1,7);
                Console.WriteLine("tom rolled " + attempts);
                numberofattempts++;
            }
            Console.WriteLine("number of attempts is: " + numberofattempts + " attempts.");
            */

            /*
            List<int> a = new List<int>();
            a.Add(13);
            a.Add(5);
            a.Add(3);
            a.Add(9);
            a.Add(4);
            for (int i=0;i<a.Count;i++)
                Console.Write(a[i]+" ");
            Console.WriteLine();
            a.RemoveAt(1);          //the method remove the element'location that equal to
            a.Remove(9);           //the method remove the element that equal to
            for (int i = 0; i < a.Count; i++)
                Console.Write(a[i] + " ");
            */


            /*
            Animal A = new Animal();                  //  example        1
            A.name = "ahmed";
            Animal.count = 10;                  //this how to access static vairable
            Console.WriteLine(A.name + "  ",Animal.count) ;
            */


            
            Dog B = new Dog();                          //example       2
            B.Bark();
            



            /*
            Dog hulk = new Dog("hulk",6,0.7f,Breed.Boxer);         //exapmle       3
            hulk.print();
            */


            /*
            DateTime curtime = DateTime.Now;
            Console.WriteLine(curtime);
            */


            /* 
            player tom = new player();                     //exapmle       4
            tom.Damage(30);                      
            Console.WriteLine(tom.health);
            tom.health = 120;      //if we did not write the set function inside the health variable here we can not say tom.health=value...because get function is for read only
            Console.WriteLine(tom.health);
            */



            /*
            sword s = new sword("Belal");                example             5
            s.equip();
            s.take_damage(20);
            s.sell();
            s.TurnIn();

            Console.WriteLine();

            Axe axe = new Axe("Fury Axe");
            axe.equip();
            axe.take_damage(15);
            axe.sell();
            axe.TurnIn();

            Console.WriteLine();

            //create an inventory
            Item[] inventory = new Item[2];           //this is an array of items meaning an array of classes that derive from the eye item interface 
            inventory[0] = s;
            inventory[1] = axe;
            //loop through and turn in all quest items
            for (int i = 0; i<inventory.Length;i++)
            {
                IpartOfQuest questItem = inventory[i] as IpartOfQuest;  //here we try to put into a variable of type IpartOfQuest
                if (questItem != null)
                    questItem.TurnIn();
//what this loop does is if the inventory marked with the IpartOfQuest taq ..if it derives from the interface ..then it is going to be transformed into questItem varibale... but if doesnt then this is not going to work and questItem is going to be equal to 0 becuase it is not a questItem and therefore and chritum will be null
            }

            Console.WriteLine();

            IDamagable[] beb = new IDamagable[2];
            beb[0] = s;
            beb[1] = axe;
            for(int i=0;i<beb.Length;i++)
            {
                POPP t = beb[i] as POPP;
                if (t != null)
                    t.letprint();
            }
            */


            /*
            //this is a simple implemntation for generic types                //example          6
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Belal",10);
            meaning.print();
            */


            /*
            //this is an implemantation for generics
            Dictionary<string, int> price = new Dictionary<string, int>();
            price.Add("watermelon", 5);
            price.Add("car", 10000);
            Console.WriteLine(price["watermelon"]);
            Console.WriteLine(price["car"]);
            */


            /*
            Console.WriteLine(Utility.compareValue(10, 3));         //example       7
            Console.WriteLine(Utility.compareType(10, 3));
            */


            Console.ReadKey();
        }
        
    }
    /*
    class Animal                   //  exapmle        1
    {
        public string name;
        public static int count = 0;
    }
    */


class Animal                                   //example       2
{
    public float happy=10;
}
class Dog : Animal
{
    public int cute=9;
    public void Bark()
    {
        Console.WriteLine("wufi");
        base.happy = 5.6f;
        Console.WriteLine(happy);
    }
}
class Cat : Animal
{
    public void meaw()
    {
        Console.WriteLine("meao");
    }
}



/*
enum Breed { Boxer, Bulldog, Chihuahua, Briard };               //example        3
class Animal
{
    public float happiness;
    public string name;
    public int age;
}
class Dog : Animal
{
    public Breed breed;
    public Dog(string _name, int _age,float _happiness,Breed _breed)
    {
        name = _name;
        age = _age;
        happiness = _happiness;
        breed = _breed;
    }
    public void print()
    {
        Console.WriteLine("name "+name);
        Console.WriteLine("age " + age);
        Console.WriteLine("happiness " + happiness);
        Console.WriteLine("breed " + breed);
    }
}
*/


/*
class player                    //exapmle       4
{
    private int _health = 100;
    public int health
    {
        get { return _health; }
       set                  //if we write this set function the variable health become for read and write
        {
            if (value <= 0)
                _health = 0;
            else if (value >= 100)
                _health = 100;
            else
                _health = value;
           }    
    }
    public void Damage(int _damge)
    {
        _health -= _damge;
    }
}
*/


    /*
    interface Item                            //example             5
    {
        string name
        {
            get;
            set;
        }
        int goldvalue
        {
            get;
            set;
        }
        void equip();
        void sell();
    }
    interface IDamagable
    {
        int durability
        {
            get;
            set;
        }
        void take_damage(int amount);
    }
    interface IpartOfQuest
    {
        void TurnIn();
    }
    interface POPP
    {
        void letprint();
    }
    class sword:Item,IDamagable,IpartOfQuest,POPP
    {
        public string name
        {
            get;
            set;
        }
        public int goldvalue
        {
            get;
            set;
        }
        public int durability
        {
            get;
            set;
        }
        public sword(string name)
        {
            this.name = name;
            goldvalue = 100;
            durability = 30;
        }
        public void equip() { Console.WriteLine(name +" equipped"); }
        public void sell() { Console.WriteLine(name + " sale for " +goldvalue+" imaginary dollars"); }
        public void take_damage(int x) 
        {
            durability -= x;
            Console.WriteLine(name+" is damaged by "+x+". It now hase a durability of "+durability);
        }
        public void TurnIn() { Console.WriteLine(name + " trun in sword class"); }
        public void letprint() { Console.WriteLine("it is an amazing sword..."); }
    }

    class Axe : Item, IDamagable,IpartOfQuest
    {
        public string name
        {
            get;
            set;
        }
        public int goldvalue
        {
            get;
            set;
        }
        public int durability
        {
            get;
            set;
        }
        public Axe(string name)
        {
            this.name = name;
            goldvalue = 100;
            durability = 30;
        }
        public void equip() { Console.WriteLine(name + " equipped"); }
        public void sell() { Console.WriteLine(name + " sale for " + goldvalue + " imaginary dollars"); }
        public void take_damage(int x)
        {
            durability -= x;
            Console.WriteLine(name + " is damaged by " + x + ". It now hase a durability of " + durability);
        }
        public void TurnIn() { Console.WriteLine(name + " trun in axe class"); }
    }
    */


    /*
    //generic type                           //example              6
    class KeyValuePair<TKey,TValue>   //these are types not value..
    {
        public TKey key;
        public TValue value;
        public KeyValuePair(TKey _key,TValue _value)
        {
            key = _key;
            value = _value;
        }
        public void print()
        { 
            Console.WriteLine("key: " +key.ToString());
            Console.WriteLine("Value: " + value.ToString());
        }
    }
    */



    /*
    class Utility                                  //example       7
    {
        public static bool compareValue<T01, T02>(T01 value1,T02 value2)
        {
            return value1.Equals(value2);
        }
        public static bool compareType<T01, T02>(T01 type1, T02 type2)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
    */



}
