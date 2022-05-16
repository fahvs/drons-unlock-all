// Decompiled with JetBrains decompiler
// Type: Registry.Properties.Resources
// Assembly: "Dron's Unlocker", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 05A23AB4-AE9D-4CC7-9B58-77B3FAA021E6
// Assembly location: C:\Users\twist\Desktop\Dron's Unlocker_protected_dump.dem.justify.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Registry.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Registry.Properties.Resources.resourceMan == null)
          Registry.Properties.Resources.resourceMan = new ResourceManager("Registry.Properties.Resources", typeof (Registry.Properties.Resources).Assembly);
        return Registry.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Registry.Properties.Resources.resourceCulture;
      set => Registry.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap giphy => (Bitmap) Registry.Properties.Resources.ResourceManager.GetObject(nameof (giphy), Registry.Properties.Resources.resourceCulture);
  }
}
