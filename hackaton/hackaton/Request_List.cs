
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
	[Activity (Label = "Request_List")]			
	public class Request_List : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			List <string> comentarios = new List<string> ();
			var texto = Intent.Extras.GetString ("comment");
			comentarios.Add (texto);
			ListAdapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, comentarios);

			// Create your application here
		}
	}
}

