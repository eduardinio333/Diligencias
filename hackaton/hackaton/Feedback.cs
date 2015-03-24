using System;
using System.Collections.Generic;
namespace hackaton
{
	public class Feedback
	{
		public string Comment;
		public int id;
		public Feedback (string a, int b)
		{
			Comment = a;
			id = b;
		}
		public string get_comment(){
			return Comment;
		}
	}
}

