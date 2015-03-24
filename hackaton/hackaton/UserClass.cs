using System;

namespace hackaton
{
	public class User
	{
		//Parametros
		public string name, lname, phone, mail, address, user, password;
		public int id;
		public User (string n, string l, string p, string m, string a, string u, string pass, int code)
		{
			name = n;
			lname = l;
			phone = p;
			mail = m;
			address = a;
			user = u;
			password = pass;
			id = code;
			//nothing
		}

	}
}

