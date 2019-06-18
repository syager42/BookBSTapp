using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISBNCourseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Book_BST myBookTree = new Book_BST();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            try
            {
                newBook.ISBN = Convert.ToInt32(textBoxISBN.Text);
                newBook.Rating = Convert.ToInt32(textBoxRating.Text);
                newBook.PubYear = Convert.ToInt32(textBoxYear.Text);
            }
            catch (Exception)
            {
                clearMessage();
                labelError.Text = "ISBN, Rating, and Year must be int values";
            }
            newBook.Title = textBoxTitle.Text;
            newBook.Author = textBoxAuthor.Text;

            if (newBook.Rating < 1 || newBook.Rating > 5)
            {
                clearMessage();
                labelError.Text = "Rating must be from 1 (worst) to 5 (best)";
            }
            else if (newBook.Author == "" || newBook.Title == "")
            {
                clearMessage();
                labelError.Text = "Author and Title are required fields";
            }
            else
            {

                try
                {
                    myBookTree.AddRec(newBook);
                    clearAll();
                    labelAdd.Text = "Book successfully added!";
                }
                catch (Exception)
                {
                    clearMessage();
                    labelError.Text = "Duplicate ISBN not permitted";
                }
                
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Book existingBook;

            try
            {
                existingBook = myBookTree.FindRec(Convert.ToInt32(textBoxISBN.Text));
                textBoxTitle.Text = existingBook.Title;
                textBoxAuthor.Text = existingBook.Author;
                textBoxRating.Text = existingBook.Rating.ToString();
                textBoxYear.Text = existingBook.PubYear.ToString();

                clearMessage();
                labelError.Text = "";
            }
            catch (Exception)
            {
                clearMessage();
                labelError.Text = "Enter a valid existing ISBN to find book";
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                myBookTree.Remove(Convert.ToInt32(textBoxISBN.Text));
                clearAll();
                labelRemove.Text = "Book successfully removed!";
            }
            catch (Exception)
            {
                clearMessage();
                labelError.Text = "Enter a valid existing ISBN to remove book";
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            getList();
        }

        private void clearAll()
        {
            textBoxISBN.Text = "";
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxYear.Text = "";
            textBoxRating.Text = "";

            labelError.Text = "";
            labelList.Text = "";
            labelAdd.Text = "";
            labelRemove.Text = "";
        }

        private void clearMessage()
        {
            labelAdd.Text = "";
            labelRemove.Text = "";
            labelList.Text = "";
        }

        private void getList()
        {
            clearAll();
            dataGridView1.DataSource = myBookTree.GetISBN();
            if (myBookTree.GetISBN().Count < 1)
            {
                labelList.Text = "No books in list!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Book List";
            clearAll();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
