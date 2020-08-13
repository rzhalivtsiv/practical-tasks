using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class TelegramMessegerAPI : IMessagingService
	{
		public void SendMessage(string text)
		{
			Console.WriteLine("Message send by Telegram API v.14.6");
			Console.WriteLine($"Text: {text} \n");
		}
	}
}
