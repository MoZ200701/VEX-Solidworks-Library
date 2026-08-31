// Measures the bounding box of specific configurations of a part.
// usage: SwMeasure <file> <cfg>[,<cfg>...]
using System;
using System.Runtime.InteropServices;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

class SwMeasure
{
    [STAThread]
    static int Main(string[] a)
    {
        if (a.Length < 2) { Console.WriteLine("usage: SwMeasure <file> <cfg,cfg,...>"); return 2; }
        ISldWorks sw;
        try { sw = (ISldWorks)Marshal.GetActiveObject("SldWorks.Application.34"); }
        catch { Console.WriteLine("no running SolidWorks"); return 1; }

        int e = 0, w = 0;
        ModelDoc2 doc = (ModelDoc2)sw.OpenDoc6(a[0], (int)swDocumentTypes_e.swDocPART,
            (int)swOpenDocOptions_e.swOpenDocOptions_Silent | (int)swOpenDocOptions_e.swOpenDocOptions_ReadOnly,
            "", ref e, ref w);
        if (doc == null) { Console.WriteLine("open failed err=" + e); return 1; }

        Console.WriteLine(System.IO.Path.GetFileName(a[0]));
        foreach (string c in a[1].Split(','))
        {
            doc.ShowConfiguration2(c);
            doc.EditRebuild3();
            string act = doc.ConfigurationManager.ActiveConfiguration.Name;
            double[] b = (double[])((PartDoc)doc).GetPartBox(true);
            double[] d = { (b[3]-b[0])/0.0254, (b[4]-b[1])/0.0254, (b[5]-b[2])/0.0254 };
            Array.Sort(d);
            Console.WriteLine("  cfg '" + c + "' (active='" + act + "') = "
                + d[2].ToString("0.0000") + " x " + d[1].ToString("0.0000") + " x " + d[0].ToString("0.0000")
                + " in   expect " + (double.Parse(c) * 0.5).ToString("0.0000"));
        }
        sw.CloseDoc(doc.GetTitle());
        return 0;
    }
}
