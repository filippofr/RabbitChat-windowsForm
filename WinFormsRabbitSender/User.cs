using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRabbitSender
{
	internal class User
	{
		public ObjectId _id {  get; set; }
		public string username { get; set; }
		public string password { get; set; }
	}
}
