using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace assessment1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            chocolates obj = new chocolates();
            obj.show();
        }
        public class chocolates
        {
            Stack<string> myStack = new Stack<string>();
            public void show()
            {
                Console.WriteLine("CHOCOLATE COLOURS: RED, GREEN, BLUE, ORANGE, YELLOW, PURPLE!");

                // Inserting the elements into the Stack
                myStack.Push("red");
                myStack.Push("red");
                myStack.Push("red");//1
                myStack.Push("green"); //2
                myStack.Push("blue"); //3
                myStack.Push("green"); //4
                myStack.Push("purple");
                
                //specifying the task to be done
                Console.WriteLine("1.ADD ");
                Console.WriteLine("2.REMOVE ");
                Console.WriteLine("3.Dispense colour ");
                Console.WriteLine("4.Dispense colour based on count ");
                Console.WriteLine("5.Display in array ");
                Console.WriteLine("6.Sorted in descending order based on count");
                Console.WriteLine("7.Changing of chocolate colour. ");
                Console.WriteLine("8.Changing the colour and displaying their count");
                Console.WriteLine("9.Fresh Picking ");
                Console.WriteLine("10.Rainbow Dispensary ");
                string option = "";
                do {
                    Console.WriteLine("enter any number from the above");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("MORE! MORE! MORE!");
                            addChocolates();
                            break;
                        case 2:
                            Console.WriteLine("LESS! LESS! LESS!");
                            removeChocolates();
                            break;
                        case 3:
                            Console.WriteLine(" One is not enough! ");
                            dispenseChocolates();
                            break;
                        case 4:
                            Console.WriteLine("My favourite color is...");
                            dispenseChocolatesOfColor();
                            break;
                        case 5:
                            Console.WriteLine("LED my chocos!");
                            noOfChocolates();
                            break;
                        case 6:
                            Console.WriteLine("Let's stack em up!");
                            sortChocolateBasedOnCount();
                            break;
                        case 7:
                            Console.WriteLine("They taste the same!");
                            Console.WriteLine("enter the color present");
                            string old = Console.ReadLine();
                            Console.WriteLine("enter the new colour to be present");
                            string new_one = Console.ReadLine();
                            changeChocolateColor(myStack, old, new_one);
                            break;
                        case 8:
                            Console.WriteLine("CHANGING OF COLOURS!");
                            Console.WriteLine("enter the color present");
                            string old1 = Console.ReadLine();
                            Console.WriteLine("enter the new colour to be present");
                            string new_one1 = Console.ReadLine();
                            Console.WriteLine("================================================");
                            changeChocolateColor(myStack, old1, new_one1);
                            changeChocolateColorAllOfxCount();
                            break;
                        case 9:
                            Console.WriteLine("CHALLENGE 1");
                            Console.WriteLine("Removal of count colours");
                            removeChocolateOfColor();
                            break;
                        case 10:
                            Console.WriteLine("CHALLENGE 2");
                            Console.WriteLine("Rainbow colours!");
                            dispenseRainbowChocolates();
                            break;
                        default:
                            Console.WriteLine("specify in correct format. ");
                            break;

                    }

                    Console.WriteLine("do you want to proceed with chocolate dispensary! yes or no");
                    option = Console.ReadLine();
                } while (string.Equals("yes", option));
                
                if(string.Equals("no", option))
                {
                    Console.WriteLine("thanks for playing!");
                    Console.WriteLine("====================================");
                }
            }
            public void addChocolates() 
            {
                Console.WriteLine("what colour do you want? ");
                string color = Console.ReadLine();
                Console.WriteLine("how much you need?");
                int count = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    myStack.Push(color);
                }
                foreach (var elem in myStack)
                {
                    Console.WriteLine(elem);
                }
            }
            public void removeChocolates()
            {
                Console.WriteLine("Will remove the recent item added");
                Console.WriteLine("Specify the number of chocolates to be removed: ");
                int count = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(myStack.Pop());
                }
                Console.WriteLine("your dispensary contains : ");
                foreach (var elem in myStack)
                {
                    Console.WriteLine(elem);
                }
            }
            public void dispenseChocolates()
            {

                Stack temp = new Stack();
                Console.WriteLine("Enter the number of chocolates you wanna get dispensed from bottom");
                int count = Convert.ToInt32(Console.ReadLine());

                while (myStack.Count != 0)
                {
                    temp.Push(myStack.Peek());
                    myStack.Pop();
                }
                string t = "";
                for (int i = 0; i < count; i++)
                { 
                    t = (string)temp.Peek();
                    Console.WriteLine(t);
                    temp.Pop();
                    myStack.Push(t);
                }
                    }
            public void dispenseChocolatesOfColor()
            {
                Stack temp = new Stack();
                Console.WriteLine("Enter your fav colour....");
                string colour2= Console.ReadLine();
                Console.WriteLine("Enter the number of chocolates you wanna get dispensed from bottom");
                int count = Convert.ToInt32(Console.ReadLine());
                
                    while (myStack.Count != 0)
                { 
                        //Console.WriteLine("entered");
                        temp.Push(myStack.Peek());
                        myStack.Pop();
                    }
               

                string t = "";
                int temp1 = 1;
                    for (int i = 0; i < count; i++)
                    {
                    if (string.Equals(colour2, temp.Peek()))
                    {
                        
                            t = (string)temp.Peek();
                            Console.WriteLine(t);

                        temp.Pop();

                    }
                    myStack.Push(t);
                }
                    
            }
            public void noOfChocolates()
            {
                Console.WriteLine("[ ");
                foreach (var elem in myStack)
                {
                    Console.Write(elem + ", ");
                }

            }
            int count1, count2, count3, count4, count5, count6 =0;
            public void sortChocolateBasedOnCount()
            {
                Stack<string> temporary = new Stack<string>();
                while (myStack.Count != 0)
                        {
                            temporary.Push(myStack.Peek());
                            myStack.Pop();
                        }
                       
                    string t = "";
                String[] arr = temporary.ToArray();
                int[] cnt = new int[20];
                for (int i = 0; i < arr.Length; i++)
                    {
                    if (arr[i] =="red")
                    {
                        count1 = count1 + 1;
                        Console.WriteLine("count of red: "+count1);
                    }
                    if (arr[i]=="green")
                    {
                        count2 = count2 + 1;
                        Console.WriteLine("count of green: " + count1);
                    }
                    if (arr[i]=="blue")
                    {
                        count3 = count3 + 1;
                        Console.WriteLine("count of blue: " + count1);
                    }
                    if (arr[i] == "yellow")
                    {
                        count4 = count4 + 1;
                        Console.WriteLine("count of yellow: " + count1);
                    }
                    if (arr[i] == "purple")
                    {
                        count4 = count5 + 1;
                        Console.WriteLine("count of purple: " + count1);
                    }
                    if (arr[i] == "orange")
                    {
                        count4 = count6 + 1;
                        Console.WriteLine("count of orange: " + count1);
                    }
                    temporary.Pop();
                    myStack.Push(t);
                    }
                cnt[0] = count1;
                cnt[1] = count2;
                cnt[2] = count3;
                cnt[3] = count4;
                cnt[4] = count5;
                cnt[5] = count6;
                Dictionary<string, Int32> choco_list = new Dictionary<string, Int32>();
                
                    choco_list.Add("red", cnt[0]);
                    choco_list.Add("blue", cnt[1]);
                    choco_list.Add("green", cnt[2]);
                choco_list.Add("yellow", cnt[3]);
                choco_list.Add("purple", cnt[4]);
                choco_list.Add("orange", cnt[5]);

                Console.WriteLine("=============");
                foreach (KeyValuePair<string, Int32> choco in choco_list.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine("There are {1} {0} chocolates. ", choco.Key, choco.Value);
                }
               

                }
            public  void changeChocolateColor<T>(Stack <T> myStack, T valueToReplace, T valueToReplaceWith, IEqualityComparer<T> comparer = null)
            {
                comparer = comparer ?? EqualityComparer<T>.Default;
                Console.WriteLine("enter te count to be changed");
                var temp = new Stack<T>();
                int coun= 0;
                int counting = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myStack.Count; i++)
                {
                    while (myStack.Count > 0)
                    {
                        if (counting >= coun)
                        {
                            var value = myStack.Pop();
                            if (comparer.Equals(value, valueToReplace))
                            {
                                myStack.Push(valueToReplaceWith);
                                break;
                            }
                            temp.Push(value);
                            count1++;
                        }
                    }
                }

                while (temp.Count > 0)
                    myStack.Push(temp.Pop());
                foreach(var elem in myStack)
                {
                    Console.WriteLine(elem);
                }
                }
            public void changeChocolateColorAllOfxCount()
            {
                Stack<string> temporary = new Stack<string>();
                while (myStack.Count != 0)
                {
                    temporary.Push(myStack.Peek());
                    myStack.Pop();
                }
                Console.WriteLine("enter the colour: ");
                string col = Console.ReadLine();
                string t = "";
                String[] arr = temporary.ToArray();
                int[] cnt = new int[20];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == col)
                    {
                        count1 = count1 + 1;
                    }
                    temporary.Pop();
                    myStack.Push(t);
                }
                cnt[0] = count1;
      
                Dictionary<string, Int32> choco_list = new Dictionary<string, Int32>();

                choco_list.Add("red", cnt[0]);
                

                Console.WriteLine("======================================");
                foreach (KeyValuePair<string, Int32> choco in choco_list.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine("There are {1} {0} chocolates. ", choco.Key, choco.Value);
                }


            }
            public void removeChocolateOfColor()
            {
                Console.WriteLine("enter the colour to remove from top: ");
                string colour_choco = Console.ReadLine();
                for(int i=0;i<myStack.Count;i++)
                {
                    if(myStack.Contains(colour_choco)==true)
                    {
                        myStack.Pop();
                    }
                }
                foreach(var elem in myStack)
                {
                    Console.WriteLine(elem);
                }
            }
            public void dispenseRainbowChocolates()
            {
                Stack temp1 = new Stack();
                int count = 0;
                String[] arr = myStack.ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "red")
                    {
                        Console.WriteLine(myStack.Peek());
                        temp1.Push(myStack.Peek());
                        myStack.Pop() ;
                        count = count + 1;
                        if (count == 3)
                        {
                            myStack.Push("VIBGYOR");

                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "green")
                    {
                        Console.WriteLine(myStack.Peek());
                        temp1.Push(myStack.Peek());
                        myStack.Pop();
                        count = count + 1;
                        if (count == 3)
                        {
                            myStack.Push("VIBGYOR");

                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "red")
                    {
                        Console.WriteLine(myStack.Peek());
                        temp1.Push(myStack.Peek());
                        myStack.Pop();
                        count = count + 1;
                        if (count == 3)
                        {
                            myStack.Push("VIBGYOR");

                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "yellow")
                    {
                        Console.WriteLine(myStack.Peek());
                        temp1.Push(myStack.Peek());
                        myStack.Pop();
                        count = count + 1;
                        if (count == 3)
                        {
                            myStack.Push("VIBGYOR");

                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "orange")
                    {
                        Console.WriteLine(myStack.Peek());
                        temp1.Push(myStack.Peek());
                        myStack.Pop();
                        count = count + 1;
                        if (count == 3)
                        {
                            myStack.Push("VIBGYOR");

                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == "purple")
                    {
                        Console.WriteLine(myStack.Peek());
                        temp1.Push(myStack.Peek());
                        myStack.Pop();
                        count = count + 1;
                        if (count == 3)
                        {
                            myStack.Push("VIBGYOR");

                        }
                    }
                }
                Stack temp2 = new Stack();
                while (myStack.Count != 0)
                {
                    Console.WriteLine(myStack.Peek());
                    temp1.Push(myStack.Peek());
                    myStack.Pop();
                    temp2.Push(myStack.Peek());
                    myStack.Pop();
                }
                while (temp2.Count != 0)
                {
                    string t = (string)temp2.Peek();
                    Console.WriteLine(t);
                    temp2.Pop();
                    myStack.Push(t);
                }
                
            }
        }
        }
        


        }
    
                

        
    



        
    
