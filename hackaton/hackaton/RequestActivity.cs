
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
	[Activity (Label = "RequestActivity")]			
	public class RequestActivity : Activity
	{
		private void spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Request);

			Spinner categoria = FindViewById<Spinner> (Resource.Id.categoria);

			categoria.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner_ItemSelected);
			var adapter = ArrayAdapter.CreateFromResource (
				this, Resource.Array.Categories, Android.Resource.Layout.SimpleSpinnerItem);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			categoria.Adapter = adapter;
			Button submit = FindViewById<Button> (Resource.Id.enviar);
			EditText texto = FindViewById<EditText> (Resource.Id.comment);
			submit.Click += delegate {
				string toast = string.Format ("Enviado");
				Toast.MakeText (this, toast, ToastLength.Long).Show ();
				Intent aux = new Intent(this, typeof(Request_List));
				aux.PutExtra("comment", texto.Text );
				StartActivity(aux);
			};
		}
	}
}

