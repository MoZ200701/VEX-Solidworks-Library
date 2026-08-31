// Lists how many configurations every .SLDPRT / .SLDASM in a tree carries.
//
// ISldWorks::GetConfigurationNames reads the names straight out of the file
// without opening the document, so this is a few seconds for a whole library
// rather than the hours a full open-each-part pass would take.
//
// Anything with more than one configuration is a candidate for
// SwExplodeConfigs. Output is TSV: count, file, names.

using System;
using System.IO;
using System.Runtime.InteropServices;
using SolidWorks.Interop.sldworks;

class SwListConfigs
{
    [STAThread]
    static int Main(string[] args)
    {
        if (args.Length < 1) { Console.WriteLine("usage: SwListConfigs <root> [outFile]"); return 2; }

        ISldWorks sw;
        try { sw = (ISldWorks)Marshal.GetActiveObject("SldWorks.Application.34"); }
        catch
        {
            try
            {
                Type t = Type.GetTypeFromProgID("SldWorks.Application.34") ?? Type.GetTypeFromProgID("SldWorks.Application");
                sw = (ISldWorks)Activator.CreateInstance(t);
                sw.Visible = true;
            }
            catch (Exception ex) { Console.WriteLine("CONNECT FAILED: " + ex.Message); return 1; }
        }

        TextWriter w = args.Length > 1 ? new StreamWriter(args[1]) : Console.Out;
        string root = args[0].TrimEnd('\\');

        foreach (string f in Directory.GetFiles(root, "*.*", SearchOption.AllDirectories))
        {
            string ext = Path.GetExtension(f).ToLowerInvariant();
            if (ext != ".sldprt" && ext != ".sldasm") continue;
            if (Path.GetFileName(f).StartsWith("~$")) continue;

            int n = 0;
            string names = "";
            try
            {
                object o = sw.GetConfigurationNames(f);
                if (o != null) { string[] a = (string[])o; n = a.Length; names = string.Join(",", a); }
            }
            catch (Exception ex) { names = "ERROR: " + ex.Message; }

            string rel = f.Substring(root.Length).TrimStart('\\');
            w.WriteLine(n + "\t" + rel + "\t" + names);
        }

        w.Flush();
        if (args.Length > 1) w.Close();
        return 0;
    }
}
