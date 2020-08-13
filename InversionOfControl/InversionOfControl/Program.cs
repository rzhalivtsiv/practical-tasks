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

			Invitation invite = new Invitation();
			invite.DistributionChannel = emailProvider;
			invite.SendInvitation("Invitation to a party for Ross");

			invite.DistributionChannel = smsProvider;
			invite.SendInvitation("Invitation to exam test for Andy");

			invite.DistributionChannel = telegramAPI;
			invite.SendInvitation("Invite to Birthday for Lili");
		}
	}
}
