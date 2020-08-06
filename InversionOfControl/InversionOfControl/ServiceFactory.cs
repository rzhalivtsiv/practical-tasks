using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	class ServiceFactory
	{
		public static EmailService GetEmailService() => new EmailService();
	}
}
