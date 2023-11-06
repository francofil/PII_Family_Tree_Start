using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestNameVisitor
    {
        public string LongestName { get; private set; } = string.Empty;

        public void Visit(Node node)
        {
            // Verifica si el nodo contiene un objeto Person
            if (node.Person != null)
            {
                string name = node.Person.Name;

                // Si el nombre actual es más largo que el más largo registrado
                if (name.Length > LongestName.Length)
                {
                    LongestName = name;
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