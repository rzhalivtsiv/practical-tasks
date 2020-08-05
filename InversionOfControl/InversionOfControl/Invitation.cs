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
			_emailService = new EmailService();
		}

		public void SendInvitation(string text)
		{
			_emailService.SendEmail(text);
		}
	}
}
