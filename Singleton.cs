using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Singleton
{
	public sealed class Singleton
	{
		// Only called when requested for the first time, and only run once
		private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

		// Getting the object from the lazy value
		public static Singleton Instance { get { return lazy.Value; } }

		// private instantiation of the singleton
		private Singleton()
		{
		}

		private string s1 = "12345";

		public string S1
		{	
			get { return lazy.Value.s1; }
			set { lazy.Value.s1 = value; }
		}

		private string s2 = "67890";

		public string S2
		{
			get { return lazy.Value.s2; }
			set { lazy.Value.s2 = value; }
		}

		public void Swap()
		{
			string sTemp = S1;
			S1 = S2;
			S2 = sTemp;
		}

		public override string ToString()
		{
			return S1 + S2;
		}
	}
}
