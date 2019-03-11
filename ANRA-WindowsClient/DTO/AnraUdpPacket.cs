using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANRA_WindowsClient.Classes;

namespace ANRA_WindowsClient.DTO
{
	public class AnraUdpPacket
	{
		public AnraUdpPacket(string token, UdpPacketTypeEnum type)
		{
			Token = token;
			DataType = type.ToString();
		}

		public string Token { get; private set; }
		public string DataType { get; private set; }
		public string Data { get; set; }
	}
}
