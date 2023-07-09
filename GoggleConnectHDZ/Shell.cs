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
        private readonly ConnectionInfo Connection;
        private readonly Dictionary<string, string> Command;

        public static string MovieList
        { 
            get
            {
               return "movielist";
            }
        }

        public Shell(string[] settings)
        {
            Connection = GoggleConnection(settings);

            //if (!GoggleConnection.IsAuthenticated)
            //  throw new Exception("Authentication failed!");

            Command = new Dictionary<string, string>();
            StringBuilder builderString = new StringBuilder("ls --full-time  /mnt/extsd/movies | awk '{print $5, $6, $7, $8, $9}' > ");
            builderString.Append(Path.Combine("//tmp//", MovieList));
            Command.Add("List", builderString.ToString());
        }

        public static ConnectionInfo GoggleConnection(string[] settings)
        {
            return new ConnectionInfo(settings[0], int.Parse(settings[1]), settings[2],
                new AuthenticationMethod[] { new PasswordAuthenticationMethod(settings[2], settings[3]) });
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

        public FileInfo CopyFileToLocal(string remoteFile, string localFile)
        {
            var scp = new ScpClient(Connection);
            scp.Connect();
            var lf = new FileInfo(localFile);
            scp.Download(remoteFile, lf);
            return lf;
        }

        public static FileInfo CopyFileToLocal(string remoteFile, string localFile, string[] settings)
        {
            var scp = new ScpClient(GoggleConnection(settings)) { BufferSize = 8 * 1024 };
            scp.Connect();
            var lf = new FileInfo(localFile);
            scp.Download(remoteFile, lf);
            return lf;
        }

        public static async Task<bool> CopyFileToLocalAsync(string remoteFile, string localFile, string[] settings)
        {
            var lf = new FileInfo(localFile);
            using (ScpClient scp = new ScpClient(GoggleConnection(settings)))
            {
                try
                {
                    await Task.Run(() => scp.Connect());
                }
                //catch (SshOperationTimeoutException)
                catch (Exception e)
                {
                    return false;
                }
                await Task.Run(() => scp.Download(remoteFile, lf));
            }
            return true;
        }

        public SshCommand CreateFileList()
        {
            var client = new SshClient(Connection);
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