using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class LibraryApplicationForm : Form
    {
        public LibraryApplicationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Identify coordinates on form where books should go. Depending on their position in the sorted list, each book is assigned a different set of coordinates. When the submit button is clicked, they should be moved to their respective coordinates.
        }
    }
}
