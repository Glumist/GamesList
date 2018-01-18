using GamesList.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesList.Forms
{
    public partial class FormPlatform : Form
    {
        public Platform EditedPlatform;

        public FormPlatform()
        {
            InitializeComponent();

            EditedPlatform = new Platform();
        }

        public FormPlatform(Platform platform)
        {
            InitializeComponent();

            EditedPlatform = platform;

            tbName.Text = platform.Name;
            tbShortName.Text = platform.ShortName;
            chbHave.Checked = platform.Have;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedPlatform.Name = tbName.Text;
            EditedPlatform.Have = chbHave.Checked;
            EditedPlatform.ShortName = tbShortName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
