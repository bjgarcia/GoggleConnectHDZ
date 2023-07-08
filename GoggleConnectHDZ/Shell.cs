using Renci.SshNet;
using Renci.SshNet.Common;
using Renci.SshNet.Async;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Collections;

namespace GoggleConnectHDZ
{
    internal class Shell
    {
        private readonly ConnectionInfo GoggleConnection;
        private readonly Dictionary<string, string> Command;

        public static string MovieList
        { 
            get
            {
               return "movielist";
            }
        }

        public static string LocalList
        {
            get
            {
                return Path.Combine(Path.GetTempPath(), MovieList);
            }
        }

        public static string RemoteList        
        {
            get
            {
                return Path.Combine("//tmp//", MovieList);
            }
        }

        public Shell(string[] settings)
        {
            GoggleConnection = new ConnectionInfo(settings[0], int.Parse(settings[1]), settings[2],
                new AuthenticationMethod[] { new PasswordAuthenticationMethod(settings[2], settings[3]) });

            //if (!GoggleConnection.IsAuthenticated)
              //  throw new Exception("Authentication failed!");

            Command = new Dictionary<string, string>();
            StringBuilder builderString = new StringBuilder("ls --full-time  /mnt/extsd/movies | awk '{print $5, $6, $7, $8, $9}' > ");
            builderString.Append(RemoteList);
            Command.Add("List", builderString.ToString());
        }

        public static string[] LoadSettings(string[] settings)
        {
            string settingsFile = Path.Combine(Path.GetTempPath(), "goggleConnSettings");
            if (File.Exists(settingsFile))
            {
                return File.ReadAllLines(settingsFile);
            }
            else
            { 
                File.WriteAllText(settingsFile, string.Join(Environment.NewLine, settings));
                return settings;
            }
        }

        public FileInfo CopyFileToLocal()
        {
            var scp = new ScpClient(GoggleConnection);
            scp.Connect();
            var lf = new FileInfo(LocalList);
            scp.Download(RemoteList, lf);
            return lf;
        }

        public async Task<bool> CopyFileToLocalAsync()
        {
            var lf = new FileInfo(LocalList);
            using (ScpClient scp = new ScpClient(GoggleConnection))
            {
                try
                {
                    await Task.Run(() => scp.Connect());
                }
                catch (SshOperationTimeoutException)
                {
                    return false;
                }
                await Task.Run(() => scp.Download(RemoteList, lf));
            }
            return true;
        }


        public SshCommand CreateFileList()
        {
            var client = new SshClient(GoggleConnection);

            SshCommand ret;
            if (!client.IsConnected)
                client.Connect();

            try
            { 
            
                ret = client.RunCommand(Command["List"]);
            }
            catch 
            {
                if (client.IsConnected)
                    client.Disconnect();

                client.Dispose();
                throw; 
            }
            finally 
            {
                client.Disconnect();
                client.Dispose();
            }
            return ret;
        }
    }
}