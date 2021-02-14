using System;

namespace GameProject1
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new IUserValidationService());
			gamerManager.Add(new Gamer
			{
				Id = 1,
				IdentityNumber = 12
			}) ;
			Console.WriteLine("Hello World!");
		}
	}
}
