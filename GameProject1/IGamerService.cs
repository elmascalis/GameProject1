﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
	interface IGamerService
	{	
		//bunlar benim operasyonlarım
		void Add(Gamer gamer);
		void Update(Gamer gamer);
		void Delete(Gamer gamer);
	}
}
