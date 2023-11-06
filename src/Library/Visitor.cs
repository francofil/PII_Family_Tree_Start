using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AgeVisitor
    {
        public int TotalAge { get; private set; }

        public AgeVisitor()
        {
            TotalAge = 0; 
        }


        public void Visit(Node node)
        {
            // Verifica si el nodo tiene una Person
            if (node.Person != null)
            {
                TotalAge += node.Person.Age;
            }

            // Recorre los hijos del nodo 
            foreach (var child in node.Children)
            {
                Visit(child);   // para asegurarse de que se visiten todos los nodos del árbol.
            }
        }

    }
}
