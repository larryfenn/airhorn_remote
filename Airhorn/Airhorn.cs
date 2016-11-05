using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Airhorn {
  public partial class Airhorn : Form {
    public Airhorn() {
      InitializeComponent();
      TcpListener listener = new TcpListener(42069); // nice
      listener.Start();
      while (true) {
        Socket client = listener.AcceptSocket();
        Console.WriteLine("Received");
        SendKeys.SendWait("S");
        client.Close();
      }
    }
  }
}
