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
        Library l = new Library(); //Create a Library object
        Dictionary<int, string> isbn = new Dictionary<int, string>(); //Create Dictionary to hold ISBN (key) and title (value)

        public LibraryApplicationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool pop = checkPopular.Checked; //Represents whether the book is popular
            Label[] labels = { lblPopular1, lblPopular2, lblPopular3, lblBook1, lblBook2, lblBook3, lblBook4, lblBook5, lblBook6 };
            Label[] isbnLabels = { lblIsbn1, lblIsbn2, lblIsbn3, lblIsbn4, lblIsbn5, lblIsbn6, lblIsbn7, lblIsbn8, lblIsbn9 };
            int r = 2; //This is used to cycle through the list of non-popular book labels, starting at index 2 (but it never actually hits index 2 because 1 is added to it - thus, it starts at lblBook1)

            //Checks to make sure ISBN is numbers only
            try
            {
                int.Parse(txtIsbn.Text);
            }
            catch (Exception invalidIsbn)
            {
                MessageBox.Show("ISBN must only be numbers.");
                throw new ArgumentException();
            }

            if (pop)
            {
                l.Popular.Add(txtTitle.Text); //Add to Popular list
                isbn.Add(int.Parse(txtIsbn.Text), txtTitle.Text); //Add to ISBN Dictionary
                l.Popular.Sort(); //Sort list alphabetically

                for (int i = 0; i < l.Popular.Count; i++)
                {
                    if (i > 2) //Ensures user won't enter more than 3 popular books
                    {
                        MessageBox.Show("You can only add up to 3 popular books.");
                        throw new ArgumentException();
                    }
                    if (l.Popular[i] != null)
                    {
                        labels[i].Text = l.Popular[i]; //Populate the label on the GUI
                        var matchingIsbn = isbn.FirstOrDefault(x => x.Value == l.Popular[i]).Key; //Find the ISBN for the current title
                        isbnLabels[i].Text = matchingIsbn.ToString(); //Display the ISBN
                    }
                }
            }
            else
            {
                l.Books.Add(txtTitle.Text); //Add to Books list
                isbn.Add(int.Parse(txtIsbn.Text), txtTitle.Text); //Add to ISBN Dictionary
                l.Books.Sort(); //Sort list alphabetically

                for (int i = 0; i < l.Books.Count; i++)
                {
                    r += 1;

                    if (l.Books[i] != null)
                    {
                        if(r > 8) //Ensures user won't enter more than 6 non-popular books
                        {
                            MessageBox.Show("You can only add up to 6 books that aren't popular.");
                            throw new ArgumentException();
                        }
                        else
                        {
                            labels[r].Text = l.Books[i]; //Populate the label on the GUI, starting with labels[r] instead of labels[i] because labels[i] would start at labels[0], and indexes 0-2 are popular books only
                            var matchingIsbn = isbn.FirstOrDefault(x => x.Value == l.Books[i]).Key; //Find the ISBN for the current title
                            isbnLabels[r].Text = matchingIsbn.ToString(); //Display the ISBN
                        }
                    }
                }
            }
        }
    }
}
