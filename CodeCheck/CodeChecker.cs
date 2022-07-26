//namespace CodeCheck

public class CodeChecker
{

    public static bool CheckCode(string text)
    {

        bool result=false;
        Stack<char> stack = new Stack<char>();

        if (text.Count() > 0)
        {
            foreach (char znak in text)
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
                                return false;
                            }
                        }

                        else if (znak == ']')
                        {
                            bool comparsion = stack.Pop() == '[';
                            if (!comparsion)
                            {
                                return false;
                            }
                        }

                        else if (znak == '}')
                        {
                            bool comparsion = stack.Pop() == '{';
                            if (!comparsion)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return  false;
                    }
                }

            }
        }

        if (stack.Count() > 0)
        {
            return false;
            
        }
        else
        {
            return true; 
        }

    }
}

