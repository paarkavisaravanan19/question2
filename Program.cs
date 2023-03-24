using System.Collections;

namespace assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            // Inserting the elements into the Stack
            myStack.Push("red");
            myStack.Push("green");
            myStack.Push("blue");
            myStack.Push("orange");
            myStack.Push("red");
            myStack.Push("yellow");

            Console.WriteLine("1.ADD ");
            Console.WriteLine("2.REMOVE ");
            Console.WriteLine("3.Dispense colour ");
            Console.WriteLine("4. count ");
            Console.WriteLine("sort(count) ");
            Console.WriteLine("enter any number from the above");
            int opt=Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    string color = Console.ReadLine();
                    int count=Convert.ToInt32(Console.ReadLine());
                    myStack.Push(color);
                    Console.WriteLine(myStack.Peek());
                    break;
                case 2:
                    Console.WriteLine("wil remove the recent item added");
                    Console.WriteLine(myStack.Pop());
                    break;
                case 3:
                    break;
            }

        }
    }
}