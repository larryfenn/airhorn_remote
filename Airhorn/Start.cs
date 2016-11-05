using System;
using System.Windows.Forms;

namespace Airhorn {
  static class Start {
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Airhorn());
    }
  }
}
