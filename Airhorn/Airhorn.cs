using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Airhorn {
  public partial class Airhorn : Form {
    public Airhorn() {
      InitializeComponent();
      TcpListener listener = new TcpListener(42069); // nice
      listener.Start();
      while (true) {
        TcpClient client = listener.AcceptTcpClient();
        SendKeys.SendWait("S");
        String sender = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\Larry Fenn\Desktop\Airhorn\airhornlog.txt", true))
        {
          file.WriteLine("{0}\t{1}", sender, DateTime.Now.ToString(new CultureInfo("en-US")));
        }
          client.Close();
      }
    }
  }
}
