using System;
using System.IO;

namespace verify_cn
{
    class Program
    {
        static void LogWrite(string UidFile, string Depth, string UID, string VpnAction)
        {
            string PathLogFolder = @"..\log\";
            if (!Directory.Exists(PathLogFolder))
            {
                Directory.CreateDirectory(PathLogFolder);
            }
            string LogFile = $"CN_debug_{DateTime.Now:yyyy.MM.dd}.txt";
            string PathLogFile = PathLogFolder + LogFile;
            //string PathLogFile = @"..\log\CN_debug.txt";
            DateTime now = DateTime.Now;
            string LogText = now.ToString() + ": " + $"FileName = {UidFile}, Depth = {Depth}, UID = {UID}, Action = {VpnAction}" + "\n";
            System.IO.File.AppendAllText(PathLogFile, LogText);
        }
        static int Main(string[] args)

        {
            string UidFile = args[0];   // FileName
            string Depth = args[1];     // Depth
            string UidInput = args[2];  // CN
            UidInput = UidInput.Substring(3); // cut 3 first symbols, because ovpn sending CN=CLIENTNAME
            string VpnAction = null;

            // if depth eq 1 need to pass it, because this step is checking CA
            if (Depth == "1") 
            {
                return 0;
            }

            if (Depth == "0")
            {
                
                var text = File.ReadAllLines(UidFile);
                foreach (var UidList in text)
                {
                    if (UidList == UidInput)
                    {
                        // Logging
                        VpnAction += "Allow";
                        LogWrite(UidFile, Depth, UidInput, VpnAction);
                        return 0;
                    }
                }
            }
            // Logging
            VpnAction += "Deny";
            LogWrite(UidFile, Depth, UidInput, VpnAction);
            return 1;
        }
    }



}
