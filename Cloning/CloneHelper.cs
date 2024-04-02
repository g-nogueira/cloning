using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloning
{
    public partial class CloneHelper : Form
    {
        MainForm _Main;
        CloneType _Type;

        public CloneHelper(MainForm main, CloneType type)
        {
            InitializeComponent();
            _Main = main;
            _Type = type;

            Options.ApplyTheme(this);

            if (_Type == CloneType.Backup)
            {
                label1.Text = "Backing up, please wait";
            }

            if (_Type == CloneType.Restore)
            {
                label1.Text = "Restoring, please wait";
            }
        }

        private async Task CloningAnimation()
        {
            switch (_Type)
            {
                case CloneType.Backup:
                {
                    var backupTasks =
                        _Main.selectedAddons.Select(a => Task.Run(() => a.Backup(_Main.CurrentBackupPath)));
                    await Task.WhenAll(backupTasks);

                    Close();
                    break;
                }
                case CloneType.Restore:
                {
                    var restoreTasks =
                        _Main.selectedAddons.Select(a => Task.Run(() => a.Restore(_Main.CurrentRestorePath)));
                    await Task.WhenAll(restoreTasks);

                    Close();
                    break;
                }
            }
        }


        private void CloneHelper_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            dotter.Start();
            CloningAnimation();
            BringToFront();
        }

        private void dotter_Tick(object sender, EventArgs e)
        {
            switch (label2.Text)
            {
                case "":
                    label2.Text = ".";
                    break;
                case ".":
                    label2.Text = "..";
                    break;
                case "..":
                    label2.Text = "...";
                    break;
                case "...":
                    label2.Text = "";
                    break;
            }
        }
    }
}