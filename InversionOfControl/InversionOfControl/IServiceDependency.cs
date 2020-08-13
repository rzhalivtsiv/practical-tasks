using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl
{
	interface IServiceDependency
	{
		void SetDependencyService(IMessagingService service);
	}
}
