﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANRA_WindowsClient.DTO;

namespace ANRA_WindowsClient
{
	public class OperationLookupItem
	{
		public Guid Gufi { get; set; }

		[JsonProperty(PropertyName = "uss_instance_id")]
		public Guid UssInstanceId { get; set; }

		[JsonProperty(PropertyName = "uss_name")]
		public string UssName { get; set; }

		[JsonProperty(PropertyName = "uas_registrations")]
		public List<UasRegistration> UasRegistrations { get; set; }

		public string State { get; set; }

	}
	
}

