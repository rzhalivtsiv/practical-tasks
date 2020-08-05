using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class EmailService
	{
		public void SendEmail(string text)
		{
			Console.WriteLine("Message send by email service");
			Console.WriteLine($"Text: {text}");
		}
	}
}
