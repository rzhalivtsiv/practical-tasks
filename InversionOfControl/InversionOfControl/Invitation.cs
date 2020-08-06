using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class Invitation
	{
		private EmailService _emailService;

		public Invitation()
		{
			_emailService = ServiceFactory.GetEmailService();
		}

		public void SendInvitation(string text)
		{
			_emailService.SendEmail(text);
		}
	}
}
