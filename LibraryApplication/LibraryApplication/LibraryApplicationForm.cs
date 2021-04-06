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
        List<string> books = new List<string>();
        List<string> popular = new List<string>();

        public LibraryApplicationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool pop = checkPopular.Checked;
            int popularLength = popular.Count;
            int booksLength = books.Count;
            Label[] labels = { lblPopular1, lblPopular2, lblPopular3, lblBook1, lblBook2, lblBook3, lblBook4, lblBook5, lblBook6 };

            if (pop)
            {
                popular.Add(txtTitle.Text);
                popular.Sort();

                for (int i = 0; i < popularLength; i++)
                {
                    if (i > 2)
                    {
                        throw new Exception("You can only add up to 3 popular books.");
                    }
                    if (popular[i] != null)
                    {
                        labels[i].Text = popular[i];
                    }
                }
            }
            else
            {
                books.Add(txtTitle.Text);
                books.Sort();

                for (int i = 3; i < booksLength; i++)
                {
                    if (i > 8)
                    {
                        throw new Exception("You can only add up to 6 books that aren't popular.");
                    }
                    if (books[i] != null)
                    {
                        labels[i].Text = books[i];
                    }
                }
            }
        }
    }
}
