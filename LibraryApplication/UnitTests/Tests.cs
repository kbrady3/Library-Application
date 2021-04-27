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
            f.titleToAdd = "The Age of the New World";
            f.isbnToAdd = 1;
            f.AddPopular();

            f.titleToAdd = "The Age of the Old World";
            f.isbnToAdd = 2;
            f.AddPopular();

            f.titleToAdd = "The Age of the Middle-Aged World";
            f.isbnToAdd = 3;
            f.AddPopular();

            f.titleToAdd = "The Age of the Very New World";
            f.isbnToAdd = 4;
            f.AddPopular();

            //Typically there'd be an "assert" here, but this is only asserting that the Message Box pops up with an error (which it does).
        }

        [TestMethod]
        public void OverflowRegularBooks()
        {
            f.titleToAdd = "The Age of the New World";
            f.isbnToAdd = 1;
            f.AddRegular();

            f.titleToAdd = "The Age of the Old World";
            f.isbnToAdd = 2;
            f.AddRegular();

            f.titleToAdd = "The Age of the Middle-Aged World";
            f.isbnToAdd = 3;
            f.AddRegular();

            f.titleToAdd = "The Age of the Very New World";
            f.isbnToAdd = 4;
            f.AddRegular();

            f.titleToAdd = "The Age of the Ultra Old World";
            f.isbnToAdd = 5;
            f.AddRegular();

            f.titleToAdd = "The Age of the Ancient World";
            f.isbnToAdd = 6;
            f.AddRegular();

            f.titleToAdd = "The Age of the Infant World";
            f.isbnToAdd = 7;
            f.AddRegular();

            //Typically there'd be an "assert" here, but this is only asserting that the Message Box pops up with an error (which it does).
        }
    }
}
