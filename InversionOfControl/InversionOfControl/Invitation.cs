using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class Invitation
	{
		private IMessagingService _messageService;

		public Invitation(IMessagingService messageProvider)
		{
			_messageService = messageProvider;
		}

		public void SendInvitation(string text)
		{
			_messageService.SendMessage(text);
		}
	}
}
