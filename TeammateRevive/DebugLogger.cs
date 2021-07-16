using System;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
public class DebugLogger
{

    public static void diag1(string message)
    {
        using (StreamWriter w = File.AppendText("TeammateRevivalLog.txt"))
        {
            w.WriteLine(message.ToString() + DateTime.Now + '\n', w);
        }

    }
    //Yellow Errors Prefixed With *WARNING* in Log File 
    public static void diag2(string message)
    {
        using (StreamWriter w = File.AppendText("TeammateRevivalLog.txt"))
        {
            w.WriteLine("*WARNING*" + message.ToString() + DateTime.Now + '\n', w);
        }
    }
    //Red Errors Prefixed With *ERROR* in Log File
    public static void diag3(string message)
    {
        using (StreamWriter w = File.AppendText("TeammateRevivalLog.txt"))
        {
            w.WriteLine("*ERROR*" + message.ToString() + DateTime.Now + '\n', w);
        }
    }
}
