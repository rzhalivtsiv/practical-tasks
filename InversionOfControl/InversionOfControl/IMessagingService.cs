using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	interface IMessagingService
	{
		void SendMessage(string text);
	}
}
