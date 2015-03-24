
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace hackaton
{
	[Activity (Label = "ProfileActivity")]			
	public class ProfileActivity : Android.App.Activity
	{
		protected override void OnCreate (Bundle bundle)
		{

			base.OnCreate (bundle);
			SetContentView(Resource.Layout.User_Profile);
			TextView name = FindViewById<TextView> (Resource.Id.nombre);
			TextView lname = FindViewById<TextView> (Resource.Id.apellido);
			TextView phone = FindViewById<TextView> (Resource.Id.telefono);
			TextView mail = FindViewById<TextView> (Resource.Id.correo);
			TextView address = FindViewById<TextView> (Resource.Id.direccion);
			TextView ida = FindViewById<TextView> (Resource.Id.id);
			Button comments = FindViewById<Button> (Resource.Id.comentarios);
			Button Request = FindViewById<Button> (Resource.Id.request);
			var persona = Intent.Extras.GetStringArrayList ("usuario") ?? new string[0];
			name.Text = persona[0];
			lname.Text = persona [1];
			phone.Text = persona [2];
			mail.Text = persona [3];
			address.Text = persona [4];
			ida.Text = persona [7];
			comments.Click += delegate {
				Intent aux = new Intent(this, typeof(CommentsActivity));
				aux.PutExtra("id", persona[7]);
				StartActivity(aux);
			};
			Request.Click += delegate {
				Intent intent = new Intent(this, typeof(RequestActivity));

				StartActivity(intent);
			};

		}
	}
}

