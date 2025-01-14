﻿using AspNetCore.Identity.Mongo.Model;



namespace SocialGuard.Api.Services.Authentication
{
	public class ApplicationUser : MongoUser<string>
	{
		public ApplicationUser() : base() { }
		public ApplicationUser(string username) : base(username)
		{
			Id = username;
		}
	}
}