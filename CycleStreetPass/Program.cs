using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
namespace CycleStreetPass
{
    class Program
    {
        static string[] macs = 
        {
            "0002727D960C",
            "4E5350414248",
            "4E5350414652",
            "4E5350414D48",
            "4E5350415335",
            "4E5350415947",
            "4E53504F4F43",
            "000D67152D82",
            "4E5350414252",
            "4E5350414655",
            "4E5350414D4B",
            "4E5350415346",
            "4E5350415957",
            "4E53504F4F44",
            "000D6715D259",
            "4E5350414343",
            "4E535041465A",
            "4E5350414D51",
            "4E535041534A",
            "4E5350415A43",
            "4E53504F4F45",
            "000D6715D544",
            "4E535041434A",
            "4E5350414739",
            "4E5350414D52",
            "4E535041534C",
            "4E5350424457",
            "4E53504F4F46",
            "000D6715D6FD",
            "4E535041434C",
            "4E5350414741",
            "4E5350414D58",
            "4E535041534E",
            "4E5350424C4B",
            "4E53504F4F47",
            "000D6715D721",
            "4E5350414352",
            "4E5350414755",
            "4E5350414E39",
            "4E5350415352",
            "4E535042534B",
            "4E53504F4F48",
            "002586D1D8A3",
            "4E5350414354",
            "4E5350414842",
            "4E5350414E41",
            "4E5350415353",
            "4E5350425435",
            "4E53504F4F49",
            "00259C521C6A",
            "4E5350414437",
            "4E5350414851",
            "4E5350414E4C",
            "4E5350415356",
            "4E5350454336",
            "4E53504F4F4A",
            "0253504F4F46",
            "4E5350414441",
            "4E5350414854",
            "4E5350414E50",
            "4E5350415435",
            "4E5350454744",
            "4E53504F4F4B",
            "340804BFAC8A",
            "4E5350414444",
            "4E5350414A47",
            "4E5350414E53",
            "4E5350415438",
            "4E53504A4150",
            "4E53504F4F4C",
            "4053504F4F47",
            "4E5350414447",
            "4E5350414A50",
            "4E5350415034",
            "4E5350415445",
            "4E53504A4432",
            "4E53504F4F4D",
            "4053504F4F48",
            "4E535041444E",
            "4E5350414B39",
            "4E5350415035",
            "4E5350415448",
            "4E53504A4438",
            "4E53504F4F4E",
            "4053504F4F49",
            "4E5350414452",
            "4E5350414B42",
            "4E5350415043",
            "4E535041544B",
            "4E53504A4452",
            "4E53504F4F4F",
            "4053504F4F50",
            "4E535041445A",
            "4E5350414B44",
            "4E5350415044",
            "4E535041544E",
            "4E53504A4542",
            "4E53504F4F50",
            "4053504F4F51",
            "4E5350414532",
            "4E5350414B48",
            "4E5350415049",
            "4E5350415451",
            "4E53504A4652",
            "4E53504F4F51",
            "4053504F4F52",
            "4E5350414533",
            "4E5350414B4B",
            "4E5350415053",
            "4E5350415454",
            "4E53504A4757",
            "4E53504F4F52",
            "4053504F4F53",
            "4E5350414534",
            "4E5350414B4E",
            "4E5350415059",
            "4E5350415457",
            "4E53504A4853",
            "4E53504F4F53",
            "4053504F4F54",
            "4E5350414545",
            "4E5350414C36",
            "4E5350415142",
            "4E5350415532",
            "4E53504A4B52",
            "4E53504F4F54",
            "4053504F4F55",
            "4E535041454B",
            "4E5350414C47",
            "4E5350415143",
            "4E5350415533",
            "4E53504A4D59",
            "4E53504F4F55",
            "4053504F4F56",
            "4E535041455A",
            "4E5350414C48",
            "4E535041514E",
            "4E5350415539",
            "4E53504A5043",
            "4E53504F4F56",
            "4E4853485254",
            "4E5350414634",
            "4E5350414C4C",
            "4E5350415243",
            "4E535041554D",
            "4E53504A5054",
            "4E5748535254",
            "4E5350413636",
            "4E5350414641",
            "4E5350414C4D",
            "4E5350415245",
            "4E5350415643",
            "4E53504A5334",
            "6036DD7E05B8",
            "4E5350413738",
            "4E5350414645",
            "4E5350414C50",
            "4E535041524D",
            "4E535041574E",
            "4E53504A544B",
            "6236DD7E05B9",
            "4E5350414132",
            "4E5350414646",
            "4E5350414D36",
            "4E5350415252",
            "4E5350415754",
            "4E53504A5641",
            "7C6193076C25",
            "4E5350414239",
            "4E535041464C",
            "4E5350414D39",
            "4E5350415254",
            "4E5350415832",
            "4E53504F4F40",
            "A6F3C10BC67E",
            "4E5350414245",
            "4E535041464D",
            "4E5350414D45",
            "4E5350415333",
            "4E5350415833",
            "4E53504F4F42",
            "CCFE3C92DF43",

            "4E53504F4F40",
            "4E53504F4F41",
            "4E53504F4F42",
            "4E53504F4F43",
            "4E53504F4F44",
            "4E53504F4F45",
            "4E53504F4F46",
            "4E53504F4F47",
            "4E53504F4F48",
            "4E53504F4F49",
            "4E53504F4F4A",
            "4E53504F4F4B",
            "4E53504F4F4C",
            "4E53504F4F4D",
            "4E53504F4F4E",
            "4E53504F4F4F",

        };

        static void StopNetwork()
        {
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan stop hostednetwork";
            p.StartInfo.UseShellExecute = false;
            p.Start();

            if (p.HasExited)
                p.Kill();
        }

        static void StartNetwork()
        {
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan start hostednetwork";
            p.StartInfo.UseShellExecute = false;
            p.Start();

            if (p.HasExited)
                p.Kill();
        }

        static void ShowNetwork()
        {
            Process p = new Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan show hostednetwork";
            p.StartInfo.UseShellExecute = false;
            p.Start();

            if (p.HasExited)
                p.Kill();
        }

        static void ChangeMac(string mac)
        {
            Process p = new Process();
            p.StartInfo.FileName = "macshift.exe";
            p.StartInfo.Arguments = string.Format("-i Wi-Fi {0}", mac);
            p.StartInfo.UseShellExecute = false;
            p.Start();

            if (p.HasExited)
                p.Kill();
        }

        static void SaveConfig(int step)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["Start"].Value = step.ToString();
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        static void Main(string[] args)
        {
            int i = int.Parse(ConfigurationManager.AppSettings["Start"]);
            if (i >= macs.Length)
                i = 0;

            //foreach (string mac in macs)
            while (true)
            {
                StopNetwork();
                Thread.Sleep(5000);
                Console.WriteLine(string.Format("mac number {0}:", i));
                ChangeMac(macs[i]);
                SaveConfig(i++);
                if (i >= macs.Length)
                    i = 0;
                Thread.Sleep(5000);
                StartNetwork();
                Thread.Sleep(5000);
                ShowNetwork();
                Thread.Sleep(300000);   //  5 minute
            }
        }
    }
}
