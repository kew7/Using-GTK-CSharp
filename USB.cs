using System;
using Gtk;
//using Mono.Unix.Native;

public partial class USB : Gtk.Window
{
   
    public USB() : base(WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void On_bStop(object sender, EventArgs e)
    {
        label.Text = "Останов...";
        ShowAll();
    }

    protected void On_bPusk(object sender, EventArgs e)
    {
        label.Text = "Запуск...";
        ShowAll();
    }
}
