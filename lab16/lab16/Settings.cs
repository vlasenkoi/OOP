using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab16
{
    public partial class Settings : Form
    {
        public string Host { get; set; }
        public int LocalPort { get; set; }
        public int RemotePort { get; set; }
        public Font ChatFont { get; set; }
        public Settings(string host, int localPort, int remotePort, Font chatFont)
        {
            InitializeComponent();
            textBoxHost.Text = host;
            textBoxLocalPort.Text = localPort.ToString();
            textBoxRemotePort.Text = remotePort.ToString();
            ChatFont = chatFont;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxLocalPort.Text, out int local) ||
        !int.TryParse(textBoxRemotePort.Text, out int remote))
            {
                MessageBox.Show("Порт повинен бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Host = textBoxHost.Text;
            LocalPort = local;
            RemotePort = remote;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = ChatFont;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                    ChatFont = fontDialog.Font;
            }
        }
    }
}
