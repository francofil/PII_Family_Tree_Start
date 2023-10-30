using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Maru", 16);
            Person person2 = new Person("Juan", 6 );
            Person person3 = new Person("Franco", 20);
            Person person4 = new Person("Mateo", 17);
            Person person5 = new Person("Emilia", 21);
            Person person6 = new Person("Benjamin", 2);
            Person person7 = new Person("Valentina", 13);


            Node n1 = new Node(1, person1);
            Node n2 = new Node(2, person2);
            Node n3 = new Node(3, person3);
            Node n4 = new Node(4, person4);
            Node n5 = new Node(5, person5);
            Node n6 = new Node(6, person6);
            Node n7 = new Node(7, person7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
        }
    }
}
