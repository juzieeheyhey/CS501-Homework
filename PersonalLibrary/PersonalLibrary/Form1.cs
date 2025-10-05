using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalLibraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.personalLibraryDataSet.Books);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtAddTitle.Text.Trim();
            string author = txtAddAuthor.Text.Trim();
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter the title and the author!");
                return;
            }
            int? year = null;
            if (!string.IsNullOrWhiteSpace(txtAddYear.Text))
            {
                if (int.TryParse(txtAddYear.Text.Trim(), out int y))
                    year = y;
                else
                {
                    MessageBox.Show("Please enter a valid year!");
                    return;
                }
            }
            string genre = txtAddGenre.Text?.Trim() ?? null;
            string status = cmbAddStatus.SelectedItem?.ToString() ?? "Available";

            try
            {
                booksTableAdapter.Insert(title, author, genre, year, status);
                this.booksTableAdapter.Fill(this.personalLibraryDataSet.Books);
                txtAddTitle.Clear();
                txtAddAuthor.Clear();
                txtAddYear.Clear();
                txtAddGenre.Clear();
                cmbAddStatus.SelectedIndex = -1;
                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }


        }

        private void gridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignore header clicks

            string colName = gridBooks.Columns[e.ColumnIndex].Name; // get column name

            var rowView = gridBooks.Rows[e.RowIndex].DataBoundItem as DataRowView; // get the data row
            if (rowView == null) return;
            
            var row = (PersonalLibraryDataSet.BooksRow)rowView.Row;

            if (colName == "UpdateColumn")
            {
                string title = row["Title"].ToString().Trim();
                string author = row["Author"].ToString().Trim();
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                    MessageBox.Show("Title and Author are required!");
                    return;
                }
                string genre = row["Genre"]?.ToString().Trim();
                string status = row["Status"]?.ToString().Trim() ?? "Available";
                int? year = null;
                string yearInput = row["Year"]?.ToString().Trim();
                if (!string.IsNullOrEmpty(yearInput))
                {
                    if (int.TryParse(yearInput, out int y))
                    {
                        year = y;
                    }
                    else
                    {
                        MessageBox.Show("Year must be a valid number!");
                        return;
                    }
                }

                // Update the book
                row.Title = title;
                row.Author = author;
                row.Genre = string.IsNullOrWhiteSpace(genre) ? (string)null : genre;
                if (year.HasValue)
                    row.Year = year.Value;
                else
                    row.SetYearNull();
                row.Status = status;

                // Save changes
                try
                {
                    gridBooks.EndEdit();
                    booksBindingSource.EndEdit();
                    booksTableAdapter.Update(row);

                    // Refresh the grid
                    this.booksTableAdapter.Fill(this.personalLibraryDataSet.Books); 
                    MessageBox.Show("Book updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message);
                }

            }
            if (colName == "DeleteColumn")
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        booksTableAdapter.Delete(row.BookID, row.Title, row.Author, row.IsGenreNull() ? null : row.Genre, row.IsYearNull() ? (int?)null : row.Year, row.Status);
                        this.booksTableAdapter.Fill(this.personalLibraryDataSet.Books); // Refresh the grid
                        MessageBox.Show("Book deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting book: " + ex.Message);
                    }
                }
            }
        }

        private void RefreshGridBooks()
        {
            // Refresh the grid so unsaved data is not shown
            gridBooks.CancelEdit();
            booksBindingSource.CancelEdit();
            this.booksTableAdapter.Fill(this.personalLibraryDataSet.Books);
        }
        private void gridBooks_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                RefreshGridBooks();
            }
        }

        private void gridBooks_Leave(object sender, EventArgs e)
        {
            RefreshGridBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.Trim();
            string author = txtSearchAuthor.Text.Trim();
            string genre = txtSearchGenre.Text.Trim();
            string status = cmbSearchStatus.SelectedItem?.ToString() ;
            int? year = null;
            if (!string.IsNullOrWhiteSpace(txtSearchYear.Text))
            {
                if (int.TryParse(txtSearchYear.Text.Trim(), out int y))
                    year = y;
                else
                {
                    MessageBox.Show("Please enter a valid year!");
                    return;
                }
            }
            try
            {
                booksTableAdapter.FillByFilters(personalLibraryDataSet.Books, title, author, genre, year, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear search filters and reload all books
            txtSearchTitle.Clear();
            txtSearchAuthor.Clear();
            txtSearchGenre.Clear();
            txtSearchYear.Clear();
            cmbSearchStatus.SelectedIndex = -1;

            // Clear add filters
            txtAddTitle.Clear();
            txtAddAuthor.Clear();
            txtAddAuthor.Clear();
            txtAddYear.Clear();
            txtAddGenre.Clear();
            cmbAddStatus.SelectedIndex = -1;
            this.booksTableAdapter.Fill(this.personalLibraryDataSet.Books);
        }
    }
}
