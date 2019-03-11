using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ANRA_WindowsClient.Classes
{
	public enum UdpPacketTypeEnum
	{
		[Description("Telemetry")]
		Telemetry,

		[Description("Detect")]
		Detect
	}
}
