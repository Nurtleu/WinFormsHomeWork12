using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW04._10
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonLevelMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTopLevelMenu.Text)) mainMenuStrip.Items.Add(textBoxTopLevelMenu.Text);
        }

        private void ButtonSubItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSubItem.Text))fileToolStripMenuItem.DropDownItems.Add(textBoxSubItem.Text);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            textBoxTopLevelMenu.Clear();
            textBoxSubItem.Clear();
        }
    }
}
