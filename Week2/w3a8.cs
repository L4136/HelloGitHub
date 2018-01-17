using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace w3a8
{
    class Program
    {
            static void Main(string[] args)
            {
                string _inputstr, _reversestr = string.Empty;
                Console.Write("Write something: ");
                _inputstr = Console.ReadLine();
                if (_inputstr != null)
                {
                    for (int i = _inputstr.Length - 1; i >= 0; i--)
                    {
                        _reversestr += _inputstr[i].ToString();
                    }
                    if (_reversestr == _inputstr)
                    {
                        Console.WriteLine("This is a Palindrome! Input = {0} and Output= {1}", _inputstr, _reversestr);
                    }
                    else
                    {
                        Console.WriteLine("This is not a Palindrome. Input = {0} and Output= {1}", _inputstr, _reversestr);
                    }
                }
                Console.ReadLine();
            }
    }
}
