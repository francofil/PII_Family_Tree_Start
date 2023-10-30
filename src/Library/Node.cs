using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        private List<Node> children = new List<Node>();
        private Person person;

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Person Person
        {
            get
            {
                return this.person; 
            }
        }    

        public Node(List<Node> children, Person person)
        {
            this.children = children;
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}
