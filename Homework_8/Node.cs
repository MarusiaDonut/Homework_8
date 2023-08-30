using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Node
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

       public void AddNode(Node root, Node toAddSalary, Node toAddName)
        {
            if (toAddSalary.Salary < root.Salary)
            {
                if (root.Left != null)
                {
                    AddNode(root.Left, toAddSalary, toAddName);
                }
                else
                {
                    root.Left = toAddName;
                    root.Left = toAddSalary;
                }
            }
            else
            {
                if (root.Right != null)
                {
                    AddNode(root.Right, toAddSalary, toAddName);
                }
                else
                {
                    root.Right = toAddSalary;
                    root.Right = toAddName;
                }
            }
        }

        public Node FindNode(Node root, double number)
        {
            if (number < root.Salary)
            {
                if (root.Left != null)
                {
                    return FindNode(root.Left, number);
                }
                return null;
            }
            if (number > root.Salary)
            {
                if (root.Right != null)
                {
                    return FindNode(root.Right, number);
                }
                return null;
            }
            return root;
        }

        public void Sort(Node originiNode)
        {

            if (originiNode.Left != null)
            {
                Sort(originiNode.Left);
            }
            Console.WriteLine("Имя сотрудника - " + originiNode.Name + ", зарплата - " + originiNode.Salary);
            if (originiNode.Right != null)
            {
                Sort(originiNode.Right);
            }
        }
    }
}
