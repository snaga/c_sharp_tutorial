// tokens.cs
using System;
// The System.Collections namespace is made available:
using System.Collections;

// Declare the Tokens class:
public class Tokens
{
    private string[] elements;

    Tokens(string source, char[] delimiters)
    {
        // Parse the string into tokens:
        elements = source.Split(delimiters);
    }

    // IEnumerable Interface Implementation:
    //   Declaration of the GetEnumerator() method 
    //   required by IEnumerable
    public TokenEnumerator GetEnumerator()
    {
        return new TokenEnumerator(this);
    }

    // Inner class implements IEnumerator interface:
    public class TokenEnumerator
    {
        private int position = -1;
        private Tokens t;

        public TokenEnumerator(Tokens t)
        {
            this.t = t;
        }

        // Declare the MoveNext method required by IEnumerator:
        public bool MoveNext()
        {
            if (position < t.elements.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Declare the Reset method required by IEnumerator:
        public void Reset()
        {
            position = -1;
        }

        // Declare the Current property required by IEnumerator:
        public string Current
        {
            get
            {
                return t.elements[position];
            }
        }
    }

    // Test Tokens, TokenEnumerator

    static void Main()
    {
        // Testing Tokens by breaking the string into tokens:
        Tokens f = new Tokens("This is a well-done program.",
           new char[] { ' ', '-' });
        foreach (int item in f)
        {
            Console.WriteLine(item);
        }
    }
}