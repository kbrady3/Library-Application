using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryApplication;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        LibraryApplicationForm f = new LibraryApplicationForm();
        Library l = new Library();

        [TestMethod]
        public void OverflowPopularBooks()
        {
            TextBox txtTitle = new TextBox();
            TextBox txtIsbn = new TextBox();

            txtTitle.Text = "The Age of the New World";
            txtIsbn.Text = "1";
            f.AddPopular();

            txtTitle.Text = "The Age of the Old World";
            txtIsbn.Text = "2";
            f.AddPopular();

            txtTitle.Text = "The Age of the Middle-Aged World";
            txtIsbn.Text = "3";
            f.AddPopular();

            txtTitle.Text = "The Age of the Very New World";
            txtIsbn.Text = "4";
            f.AddPopular();
        }

        [TestMethod]
        public void OverflowRegularBooks()
        {

        }
    }
}
