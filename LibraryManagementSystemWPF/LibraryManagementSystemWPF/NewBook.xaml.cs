using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Validator;

namespace LibraryManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for NewBook.xaml
    /// </summary>
    public partial class NewBook : Window
    {

        public Book Book;
        private int Count;

        public NewBook(int count)
        {
            InitializeComponent();
            Count = count;
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (!Validator.Validator.CheckString(TB_Title.Text))
            {
                MessageBox.Show("Invalid Title");
                return;
            }
            if (!Validator.Validator.CheckString(TB_Author.Text))
            {
                MessageBox.Show("Invalid Author");
                return;
            }

            Book = new Book()
            {
                BookId = Count,
                Title = TB_Title.Text,
                Author = TB_Author.Text,
                PublicationDate = DP_Date.DisplayDate,
                IsBorrowed = false,
            };

            this.Close();
        }
    }
}
