using System;
using System.Runtime.InteropServices;
using SolidWorks.Interop.sldworks;
class SwProbeVersion {
  [STAThread] static int Main(string[] a) {
    ISldWorks sw;
    try { sw = (ISldWorks)Marshal.GetActiveObject("SldWorks.Application.34"); }
    catch { Console.WriteLine("no running SolidWorks"); return 1; }
    Console.WriteLine("GetLatestSupportedFileVersion = " + sw.GetLatestSupportedFileVersion());
    foreach (string f in a) {
      try {
        object o = sw.VersionHistory(f);
        string[] v = o as string[];
        Console.WriteLine(System.IO.Path.GetFileName(f) + "  ->  " + (v == null ? "(null)" : string.Join(" | ", v)));
      } catch (Exception ex) { Console.WriteLine(f + " ERR " + ex.Message); }
    }
    return 0;
  }
}
