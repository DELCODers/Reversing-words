using System;
using System.Collections;

namespace StringReverseUsingStack
{
    public static class StringReverse
    {
        // Reverse ExtentionMethod  
        public static string Reverse(this string str)
        {
            // calling StringReverseUsingStack  
            return Program.StringReverseUsingStack(str);
        }
    }
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Please enter the word you would like to reverse:");
            string sampleText = Console.ReadLine();
            if (string.IsNullOrEmpty(sampleText))
                sampleText = "CSharpcorner";
            
            
            var reverseText = StringReverseUsingStack(sampleText);
            Console.WriteLine($"Your Word or words reversed is : {reverseText}");
            
        }
        public static string StringReverseUsingStack(string str)
        {
            var reversedStr = "";
            Stack myStack = new Stack();
            foreach (var t in str)
                myStack.Push(t);
            while (myStack.Count > 0)
                reversedStr += myStack.Pop();
            return reversedStr;
        }
    }
}
