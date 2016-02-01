using System;
using Gtk;

namespace TestProjekt
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Console.WriteLine ("Hello world");

			Application.Run ();
		}
	}
}
