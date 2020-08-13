using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class Invitation
	{
		private IMessagingService _emailService;

		public Invitation()
		{
			_emailService = ServiceFactory.GetEmailService();
		}

		public void SendInvitation(string text)
		{
			_emailService.SendMessage(text);
		}
	}
}
