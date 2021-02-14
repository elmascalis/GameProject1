using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{	
	//MicroService
	class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;

		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}

		public void Add(Gamer gamer/*, IUserValidationService userValidationService*/)
		{
			if (_userValidationService.Validate(gamer)==true)
			{
				Console.WriteLine("kayıt oldu");
			}
			else
			{
				Console.WriteLine("kayıt basarısız");
			}
		}

	

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Kayıt sildi");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("Kayıt güncellendi");
		}
	}
}
