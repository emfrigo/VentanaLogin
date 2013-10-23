using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}	

	protected void botonApachurrado (object sender, EventArgs e)
	{
		if (txtUsuario.Text == "manis" && txtPass.Text == "12345") {
			new MessageDialog (
				this, 
				DialogFlags.Modal,
				MessageType.Info,
				ButtonsType.Close,
				"Bienvenido",
				this.Title = "Bienvenido"
				).Show();
		}
		else new MessageDialog(
			this,
			DialogFlags.Modal,
			MessageType.Error,
			ButtonsType.Close,
			"Algo anda mal",
			this.Title = "Error"
			).Show();

	}

}
