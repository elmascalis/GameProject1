using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
	class UserValidationManager : IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{
			if (gamer.BirthDateYear==1987 && gamer.FirstName=="elmas" && gamer.LastName=="çalış" && gamer.IdentityNumber==1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
