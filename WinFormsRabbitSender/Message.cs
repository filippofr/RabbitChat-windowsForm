﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRabbitSender
{
	internal class Message
	{
		public ObjectId _id { get; set; }
		public string sender { get; set; }
		public string reciver { get; set; }
		public string text { get; set; }
	}
}
