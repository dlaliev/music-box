﻿namespace OnlineShopWebApp.Models
{
	public class UsersManager : IUsersManager
	{
		private readonly List<User> users = new List<User>();

		public List<User> GetAll()
		{
			return users;
		}

		public void Add(User user)
		{
			users.Add(user);
		}

		public User TryGetByName(string name)
		{
			return users.FirstOrDefault(user => user.Name == name);
		}
	}
}
