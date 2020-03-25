using System;

namespace _26_03_2020
{

    public class Humen
    {
        public string name;

        public Humen(string name  )
        {
            this.name = name;  
        }
    }

    public class Person : Humen
    {
        public int age;

        public Person(string name ):base (name)
        {

        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        Person p = new Person("kobi");
        Console.WriteLine(p);

        Person p1 = new Person("koko", 99);

            Console.WriteLine("+++++++++++++++{0} ", p);  
            Console.WriteLine(" {0}  + {1}", p1.name, p.name);



            Console.ReadKey();
        }
    }
}


//        Person p = new Person("danny", 18);
//    }
//}

//public class Human
//{
//    public string name;
//    public Human(string name)
//    {
//        this.name = name;
//    }
//}

//public class Person : Human
//{
//    public int age;
//    public Person(string name) : base(name)
//    {

//    }

//    public Person(string name, int age) : this(name)
//    {
//        this.age = age;
//    }
//}
