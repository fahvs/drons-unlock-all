// Decompiled with JetBrains decompiler
// Type: Registry.Program
// Assembly: "Dron's Unlocker", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05A23AB4-AE9D-4CC7-9B58-77B3FAA021E6
// Assembly location: C:\Users\twist\Desktop\Dron's Unlocker_protected_dump.dem.justify.exe

using System;
using System.Windows.Forms;

namespace Registry
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Login());
    }
  }
}
