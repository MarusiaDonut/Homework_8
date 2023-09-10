namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 0;
            Node node = new Node();
            Node root = null;
            string name = "";
            do
            {
                Console.WriteLine("Введите имя сотрудника.");
                name = Console.ReadLine();
                if (name != "")
                {
                    Console.WriteLine("Введите зарплату сотрудника.");
                    if (Int32.TryParse(Console.ReadLine(), out salary))
                    {

                        if (root == null)
                        {
                            root = new Node()
                            {
                                Salary = salary,
                                Name = name
                            };
                        }
                        else
                        {
                            node.AddNode(root, new Node
                            {
                                Salary = salary,
                                Name = name

                            }, new Node
                            {
                                Salary = salary,
                                Name = name
                            });
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите зарплату числом.");
                    }
                }
                else
                {
                    break;
                }
               
            }
            while (name != "");

            node.PrintSort(root);

            Console.WriteLine("Какой размер зарплаты вас интересует?");
            while (true)
            {
                int salaryFind = 0;
                if (int.TryParse(Console.ReadLine(), out salaryFind))
                {
                    if (salaryFind == 0)
                    {
                        break;
                    }
                    var n = node.FindNode(root, salaryFind);
                    if (node == null)
                    {
                        Console.WriteLine("Такого сотрудника не существует.");
                    }
                    else if (n == null)
                    {
                        Console.WriteLine("Такой зарплаты не существует.");
                    }
                    else
                    {
                        Console.WriteLine($"Найдена зарплата {n.Salary} у сотрудника {n.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Введите зарплату числом.");
                }    
            }
        }
    }
}