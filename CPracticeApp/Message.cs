using System;
using System.Collections.Generic;
using System.Text;

namespace CPracticeApp
{
    class Message {

        string textBody = "Matt", title;
        int id;

        public void SetMessage(string message) {

            message += textBody;
            Console.WriteLine(message);

        }

    }
}
