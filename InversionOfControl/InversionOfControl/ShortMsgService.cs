using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class ShortMsgService : IMessagingService
	{
		public void SendMessage(string text)
		{
			Console.WriteLine("Message send by SMS");
			Console.WriteLine($"Text: {text} \n");
		}
	}
}
