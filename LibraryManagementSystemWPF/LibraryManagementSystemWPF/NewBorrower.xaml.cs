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
    public partial class NewBorrower : Window
    {

        public Borrower Borrower;
        private int Count;

        public NewBorrower(int count)
        {
            InitializeComponent();
            Count = count;
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (!Validator.Validator.CheckString(TB_Name.Text))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            if (!Validator.Validator.CheckEmail(TB_Email.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }

            Borrower = new Borrower()
            {
                BorrowerId = Count,
                Name = TB_Name.Text,
                Email = TB_Email.Text,
                DateOfMembership = DP_Date.DisplayDate,
            };

            this.Close();
        }
    }
}
