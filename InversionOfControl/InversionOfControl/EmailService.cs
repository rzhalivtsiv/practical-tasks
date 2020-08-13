using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class EmailService : IMessagingService
	{
		public void SendMessage(string text)
		{
			Console.WriteLine("Message send by email service");
			Console.WriteLine($"Text: {text}");
		}
	}
}
