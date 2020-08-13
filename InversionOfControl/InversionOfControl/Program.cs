using System;

namespace InversionOfControl
{
	class Program
	{
		static void Main(string[] args)
		{
			IMessagingService emailProvider = new EmailService();
			IMessagingService smsProvider = new ShortMsgService();
			IMessagingService telegramAPI = new TelegramMessegerAPI();

			Invitation emailInvite = new Invitation(emailProvider);
			emailInvite.SendInvitation("Invitation to a party for Ross");

			Invitation smsInvite = new Invitation(smsProvider);
			smsInvite.SendInvitation("Invitation to exam test for Andy");

			Invitation tegramIvite = new Invitation(telegramAPI);
			tegramIvite.SendInvitation("Invite to Birthday for Lili");
		}
	}
}
