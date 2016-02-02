using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	Button gtkClickMe;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		gtkClickMe = new Button ();
		gtkClickMe.Label = "str";
		this.Add (gtkClickMe);

		foreach (var w in this.Children) 
		{
			Console.WriteLine (w.Name);
		}
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
	}
}
