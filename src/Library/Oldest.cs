using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class OldestVisitor
    {
        public Person Oldest { get; private set; }

        public OldestVisitor()
        {
            Oldest= null;
        }


        public void Visit(Node node)
        {
            // Verifico si el nodo no tiene hijos
            if (node.Children.Count == 0)
            {
                if (Oldest == null || node.Person.Age > Oldest.Age)
                {
                    Oldest = node.Person;
                }
            }

            // Recorre los nodos hijos del nodo actual
            foreach (var child in node.Children)
            {
                Visit(child);
            }
        }
    }
}