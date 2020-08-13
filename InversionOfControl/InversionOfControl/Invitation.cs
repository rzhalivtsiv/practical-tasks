using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class Invitation
	{
		private IMessagingService _messageService;

		public IMessagingService DistributionChannel 
		{  
			set 
			{
				_messageService = value;
			} 
		}

		public Invitation() { }

		public Invitation(IMessagingService messageProvider)
		{
			_messageService = messageProvider;
		}

		public void SendInvitation(string text)
		{
			if (_messageService == null)
			{
				Console.WriteLine("ERROR! Fails to send invite - dependency service is null!");
			}
			else
			{
				_messageService.SendMessage(text);
			}
		}
	}
}
