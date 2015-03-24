using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace hackaton
{

	[Activity (Label = "hackaton", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count =1;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			List<User> Usuarios = new List<User> ();
			Usuarios.Add(new User("Eduardo", "Alonzo", "9982429063",
				"eduardinio33340@gmail.com", "smz 46 mz 11", "eduardinio", "alonzo", count));
			count++;
			Usuarios.Add(new User("Pedro", "Gonzalez", "9982589674",
				"pedro.gonzalez@gmail.com", "cancun Qroo", "Username", "Password", count));
			count++;
			Usuarios.Add(new User("Luis", "Alonzo", "9982487459",
				"luis.alonzo@gmail.com", "cancun Qroo", "luis", "alonzo", count));
			count++;
			Usuarios.Add(new User("Nicol", "Rivero", "9982569841",
				"nicol.rivero@gmail.com", "smz 46 mz 11", "nicol", "rivero", count));
			count++;
			Usuarios.Add(new User("Mr", "Patata", "9982258963",
				"mr.patata@gmail.com", "smz 46 mz 11", "mr", "patata", count));
			count++;
			Usuarios.Add(new User("Memo", "Peniche", "9982916870",
				"memo.peniche93@gmail.com", "smz 50 mz 26", "memolestas", "pez",count));
			count++;
			Usuarios.Add(new User("Maria", "Perez", "9982818060",
				"maria@gmail.com", "Cancun Qroo", "maria", "password",count));
			count++;
			Usuarios.Add(new User("Juan", "Alberto", "9991908970",
				"jal@gmail.com", "Cancun Qroo", "alberth", "hola",count));
			count++;
			Usuarios.Add(new User("Paco", "Pedro", "991245478",
				"paco@gmail.com", "Cancun Qroo", "paco", "mundo",count));
			count++;
			Usuarios.Add(new User("Jose", "Falcon", "9865321452",
				"jose@gmail.com", "Cancun Qroo", "jose", "curso",count));
			count++;
			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);
			SetContentView (Resource.Layout.Login_Screen);
			Button log = FindViewById<Button> (Resource.Id.login);
			EditText user = FindViewById<EditText> (Resource.Id.username);
			EditText pass = FindViewById<EditText> (Resource.Id.password);
			log.Click += delegate {
				foreach (var i in Usuarios) {
					if (i.user == user.Text) {
						if (i.password == pass.Text) {
							List<string> persona = new List<string> ();
							persona.Add (i.name);
							persona.Add (i.lname);
							persona.Add (i.phone);
							persona.Add (i.mail);
							persona.Add (i.address);
							persona.Add (i.user);
							persona.Add (i.password);
							persona.Add (i.id.ToString ());
							var aux = new Intent (this, typeof(ProfileActivity));
							aux.PutStringArrayListExtra ("usuario", persona);
							StartActivity (aux);

						}
				
					}
				}
			};
		}
	}
}


