using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchServerSelector
{
    public partial class MainForm : Form
    {
        private ServerSelector sc;
        public MainForm()
        {
            InitializeComponent();
            sc = new ServerSelector();
            sc.deleteRules();
            info_label.Text = "No servers selected.";
        }

        private void playNA_btn_Click(object sender, EventArgs e)
        {
            sc.deleteRules();
            sc.playOnNA();
            info_label.Text = "NA servers selected.";
        }

        private void playMENA_btn_Click(object sender, EventArgs e)
        {
            sc.deleteRules();
            sc.playOnMiddleEast();
            info_label.Text = "Middle East servers selected.";
        }

        private void unblock_btn_Click(object sender, EventArgs e)
        {
            sc.deleteRules();
            info_label.Text = "Unblocked all servers.";
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            sc.deleteRules();
        }
    }
}
