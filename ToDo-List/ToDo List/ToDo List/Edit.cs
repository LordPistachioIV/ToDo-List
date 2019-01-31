using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class Edit : Form
    {
        public string originalLine, lineAmended;

        public Edit()
        {
            InitializeComponent();
        }

        private void editItemTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lineAmended = editItemTxt.Text;
                this.Hide();
            }
            //Displayed is a message informing the user to press enter when done editing.
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            editItemTxt.Text = originalLine;
            //Getting the item from the main form so the user knows what they are editing.
        }

        public string TextBoxText
        {
            get { return editItemTxt.Text;  }
        }
    }
}
