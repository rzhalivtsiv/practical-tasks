using System;

namespace InversionOfControl
{
	class Program
	{
		static void Main(string[] args)
		{
			Invitation invite = new Invitation();
			invite.SendInvitation("Invitation to a party for Ross");
		}
	}
}
