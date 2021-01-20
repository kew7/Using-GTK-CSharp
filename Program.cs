using System;
using Gtk;

namespace USBRead
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            USB win = new USB();
            win.Show();
           // win.Resize(320, 200);
            win.ShowAll();
            Application.Run();
        }
    }
}
