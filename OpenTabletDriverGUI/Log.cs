using System;
using System.Diagnostics;

namespace OpenTabletDriverGUI
{
    internal static class Log
    {
        public static void Write(string text)
        {
            Trace.Write(text);
        }

        public static void WriteLine(string text)
        {
            Trace.WriteLine(text);
        }

        public static void WriteLine(string prefix, string text)
        {
            WriteLine($"[{prefix.ToUpper()}] {text}");
        }
        
        public static void WriteException(Exception ex)
        {
            WriteLine(ex.GetType().Name, ex.Message);
        }

        public static void Info(string text)
        {
            WriteLine("INFO", text);
        }

        public static void Fail(string text)
        {
            WriteLine("FAIL", text);
        }

        public static void Error(string text)
        {
            WriteLine("ERROR", text);
        }
    }
}