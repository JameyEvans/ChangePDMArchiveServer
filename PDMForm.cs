using ChangePDMArchiveServer;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;

namespace ChangePDMArchiveServer
{
    public partial class PDMForm : MaterialForm
    {
        public List<Server> ServerNames { get; set; }
        public List<string> VaultNames { get; set; }

        public PDMForm()
        {
            InitializeComponent();
            // populate server names from config file
            try
            {
                var json = File.ReadAllText("config.json");
                ServerConfig serverConfig = JsonConvert.DeserializeObject<ServerConfig>(json);
                ServerNames = serverConfig.Servers;
                VaultNames = serverConfig.VaultNames;
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found error
                MessageBox.Show("Config file not found. Please make sure the config.json file exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                MessageBox.Show("Error deserializing the config file. Please make sure the config.json file is valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred while reading the config file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // sort by ping time
            ServerNames.Sort((x, y) => {
                if (x.Ping < 0)
                {
                    return 1;
                }
                return x.Ping.CompareTo(y.Ping);
                });



            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            comboTargetServer.DataSource = ServerNames;
            comboTargetServer.DisplayMember = comboTargetServer.ValueMember = "FormDisplay";
            comboTargetServer.SelectedIndex = 0;

            foreach ( var vault in ServerNames[0].Vaults)
            {
                comboVault.Items.Add(vault);
            }
            if (comboVault.Items.Count > 0)
            {
                comboVault.SelectedIndex = 0;
            }
        }

        private string GetCurrentArchiveServer()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey($"SOFTWARE\\SolidWorks\\Applications\\PDMWorks Enterprise\\Databases\\{comboVault.SelectedItem}", false);
            if (rk == null)
            {
                return "NOT FOUND";
            }

            string currentServer = rk.GetValue("ServerLoc")?.ToString() ?? "NOT FOUND";
            rk.Close();
            rk.Dispose();
            return currentServer;
        }

        private void ChangeArchiveServer(string vaultName, string serverName)
        {
            string txt = $"Vault = {vaultName}{Environment.NewLine}Server = {serverName}{Environment.NewLine}";
            RegistryKey rk1 = Registry.LocalMachine.OpenSubKey($"SOFTWARE\\SolidWorks\\Applications\\PDMWorks Enterprise\\Databases\\{comboVault.SelectedItem}", true);
            RegistryKey rk2 = Registry.LocalMachine.OpenSubKey($"SOFTWARE\\WOW6432Node\\SolidWorks\\Applications\\PDMWorks Enterprise\\Databases\\{comboVault.SelectedItem}", true);
            try
            {


                if (rk1 == null)
                {
                    throw new Exception("PDM registry not detected. PDM may not be installed");
                }

                string newValue = ((Server)comboTargetServer.SelectedItem).Name;
                if (String.IsNullOrEmpty(newValue))
                {
                    throw new InvalidDataException("No target server selected");
                }

                rk1.SetValue("ServerLoc", newValue);

                if (rk2 == null)
                {
                    rk2 = Registry.LocalMachine.CreateSubKey($"SOFTWARE\\WOW6432Node\\SolidWorks\\Applications\\PDMWorks Enterprise\\Databases\\{comboVault.SelectedItem}");
                }
                rk2.SetValue("ServerLoc", newValue);

                lblCurrentServerValue.Text = GetCurrentArchiveServer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                rk1.Close();
                rk1.Dispose();
                
                rk2?.Close();
                rk2?.Dispose();
                
            }
        }

        private void PDMForm_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeArchiveServer(comboVault.SelectedItem.ToString(), ((Server)comboTargetServer.SelectedItem).Name);
                if (checkBoxRestartOnUpdate.Checked)
                {
                    SoftRebootPdm();
                }
                txtBoxResults.Text = $"Successfully updated target archive server to {((Server)comboTargetServer.SelectedItem).Name} for {comboVault.SelectedItem.ToString()} vault.";
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found error
                txtBoxResults.Text = $"ERROR: Config file not found. Please make sure the config.json file exists.";
            }
            catch (JsonException ex)
            {
                // Handle JSON deserialization error
                txtBoxResults.Text = $"ERROR: Error deserializing the config file. Please make sure the config.json file is valid.";
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                txtBoxResults.Text = $"ERROR: An error occurred while updating the target archive server: {ex.Message}";
            }
        }

        private void comboVault_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrentServerValue.Text = GetCurrentArchiveServer();
        }

        private void comboTargetServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get vaults for selected server
            var server = (Server)comboTargetServer.SelectedItem;
            comboVault.Items.Clear();
            foreach (var vault in server.Vaults)
            {
                comboVault.Items.Add(vault);
            }
            comboVault.SelectedIndex = 0;
        }

        private void SoftRebootPdm()
        {

            // Get explorer, viewserver, and edmserver processes
            Process[] explorerProcesses = Process.GetProcessesByName("explorer");

            Process[] edmServerProcesses = Process.GetProcessesByName("EdmServer");
            Process[] viewServerProcesses = Process.GetProcessesByName("ViewServer");

            // Stop viewserver and edmservers
            viewServerProcesses.ToList().ForEach(p => { p.Kill(); p.Dispose();});
            edmServerProcesses.ToList().ForEach(p => { p.Kill(); p.Dispose(); });

            // Stop explorer.exe
            explorerProcesses.ToList().ForEach(p => { p.Kill(); p.Dispose(); });           
           

            // Restart explorer.exe if not already running
            Process[] activeExplorer = Process.GetProcessesByName("explorer");
            if (activeExplorer.Length == 0)
            {
                Process explorerProcess = new Process();
                explorerProcess.StartInfo.FileName = "explorer.exe";
                explorerProcess.StartInfo.UseShellExecute = true;
                explorerProcess.Start();
                explorerProcess.Dispose();
            }
            
        }

        private void btn_restartPdm_Click(object sender, EventArgs e)
        {
            SoftRebootPdm();
        }
    }
}