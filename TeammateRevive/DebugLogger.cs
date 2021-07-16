using System;
using System.IO;
using System.Globalization;
public class DebugLogger
{
    public static void diagInit()
    {
        using (StreamWriter writer = new StreamWriter(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\log" + DateTime.Now + ".txt", true))
        {
            writer.WriteLine("" + DateTime.Now + '\n');
        }

    }
    public static void diag1(string message)
    {
        using (StreamWriter writer = new StreamWriter(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\log.txt", true))
        {
            writer.WriteLine(message.ToString() + DateTime.Now + '\n');
        }

    }
    //Yellow Errors Prefixed With *WARNING* in Log File 
    public static void diag2(string message)
    {
        using (StreamWriter writer = new StreamWriter(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\log.txt", true))
        {
            writer.WriteLine("*WARNING*" + message.ToString() + DateTime.Now + '\n');
        }
    }
    //Red Errors Prefixed With *ERROR* in Log File
    public static void diag3(string message)
    {
        using (StreamWriter writer = new StreamWriter(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\log.txt", true))
        {
            writer.WriteLine("*ERROR*" + message.ToString() + DateTime.Now + '\n');
        }
    }
}
