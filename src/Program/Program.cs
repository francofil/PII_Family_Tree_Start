using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Maru", 16);
            Person person2 = new Person("Juan", 6);
            Person person3 = new Person("Franco", 20);
            Person person4 = new Person("Mateo", 17);
            Person person5 = new Person("Emilia", 21);
            Person person6 = new Person("Benjamin", 2);
            Person person7 = new Person("Valentina", 13);

            List<Node> hijos1 = new List<Node>();
            Node n1 = new Node(hijos1, person1);

            List<Node> hijos2 = new List<Node>();
            Node n2 = new Node(hijos2, person2);

            List<Node> hijos3 = new List<Node>();
            Node n3 = new Node(hijos3, person3);

            List<Node> hijos4 = new List<Node>();
            Node n4 = new Node(hijos4, person4);

            List<Node> hijos5 = new List<Node>();
            Node n5 = new Node(hijos5, person5);

            List<Node> hijos6 = new List<Node>();
            Node n6 = new Node(hijos6, person6);

            List<Node> hijos7 = new List<Node>();
            Node n7 = new Node(hijos7, person7);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí



            AgeVisitor ageVisitor = new AgeVisitor();

            // Visitar el nodo raíz para calcular la suma de edades
            ageVisitor.Visit(n1);

            int totalAge = ageVisitor.TotalAge;

            Console.WriteLine("La suma de las edades de la familia es: " + totalAge);
        }
    }
}
