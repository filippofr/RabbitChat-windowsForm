using MongoDB.Driver.Core.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRabbitSender
{
	internal class Environment
	{
		private static readonly string username = "filippofr";
		private static readonly string password = "DatabaseSicuro99";
		public static string DbUrl {
			get { return $"mongodb+srv://{username}:{password}@clusterfilippo.t2ui8vk.mongodb.net/"; }
		}
	}
}
