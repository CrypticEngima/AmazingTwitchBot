﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingTwitchBot.Agent.Rules
{
    public class HelloRule : IChatMessageRule
    {
        public bool IsTextMatched(string chatMessage)
        {
            //todo:  evaluate text length, rather than startwith
            return chatMessage.StartsWith("hi ", StringComparison.InvariantCultureIgnoreCase);
        }

        public string ReturnedMessage(TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            return $"Hey there { e.ChatMessage.DisplayName }.";
        }
    }
}
