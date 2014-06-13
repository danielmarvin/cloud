using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
	public class UserRepository
	{
		private User[] users = {
										  new User {Name="dank", Age=50},
										  new User {Name="carl", Age=60}
									  };

		public IEnumerable<User> GetAll()
		{
			return users;
		}
	}
}
