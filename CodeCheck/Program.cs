using System;
/*
while (true)
{
    try
    {
        Console.WriteLine("write your text:");


        string inseredtext = Console.ReadLine();

        Stack<char> stack = new Stack<char>();

        if (inseredtext.Count() > 0)
        {
            foreach (char znak in inseredtext)
            {
                if (znak == '(' || znak == '[' || znak == '{')
                {
                    stack.Push(znak);
                }

                if (znak == ')' || znak == ']' || znak == '}')
                {
                    if (stack.Count() > 0)
                    {
                        if (znak == ')')
                        {
                            bool comparsion = stack.Pop() == '(';
                            if (!comparsion)
                            {
                                throw new ArgumentException();
                            }
                        }

                        else if (znak == ']')
                        {
                            bool comparsion = stack.Pop() == '[';
                            if (!comparsion)
                            {
                                throw new ArgumentException();
                            }
                        }

                        else if (znak == '}')
                        {
                            bool comparsion = stack.Pop() == '{';
                            if (!comparsion)
                            {
                                throw new ArgumentException();
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }

            }

        }
        if (stack.Count() > 0)
        { throw new ArgumentException(); }
        else if (stack.Count() == 0)
        {
            Console.WriteLine("write text its OK");

        }
        else
        {
            Console.WriteLine("Write text!");
        }

    }


    catch (ArgumentException e)
    {
        Console.WriteLine("Your text its Wrong!");
        Console.WriteLine(e); }
}
*/
Console.BackgroundColor=ConsoleColor.DarkBlue;

while (true)
{

    Console.WriteLine("Write text:");
    string text = Console.ReadLine();

    bool result = CodeChecker.CheckCode(text);
    if (result)
    {
        Console.WriteLine("Your text its OK");
    }
    if (!result)
    {
        Console.WriteLine("Your text its Wrong!");

    }
}
