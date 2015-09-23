using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CommandAS.Tools;

namespace Spyhole
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      string fnSession = null;
      bool isRun = false;
      foreach (string prm in args)
      {
        if (prm.ToLower().IndexOf("--session=") == 0)
        {
          fnSession = prm.Substring(10);
        }
        else if (prm.ToLower().IndexOf("-s=") == 0)
        {
          fnSession = prm.Substring(3);
        }
        else if (prm.ToLower().IndexOf("--run") == 0 || prm.ToLower().IndexOf("-r") == 0)
        {
          isRun = true;
        }
      }

      if (!CheckOneInstance.IsInstanceExist(true, "Spyhole"))
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        frmSpyhole frm = new frmSpyhole();
        frm.pIsRunAtOnce = isRun;
        Application.Run(frm);
      }
    }
  }
}