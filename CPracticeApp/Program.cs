using System;

namespace CPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            string something = "Hello, ";
            message.SetMessage(something);
        }
    }
}
