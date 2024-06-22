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
    public partial class NewBorrow : Window
    {

        public Borrow Borrow;
        private int Count;
        private int BookMax;
        private int BorrowerMax;

        public NewBorrow(int count, int bookMax, int borrowerMax)
        {
            InitializeComponent();
            Count = count;
            BookMax = bookMax;
            BorrowerMax = borrowerMax;
            this.LB_BookId.Content += $" ({bookMax}): ";
            this.LB_BorrowerId.Content += $" ({bookMax}): ";
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            Tuple<bool, int> BookId = Validator.Validator.CheckInt(TB_BookId.Text, Max: BookMax);
            Tuple<bool, int> BorrowerId = Validator.Validator.CheckInt(TB_BorrowerId.Text, Max: BookMax);

            if (!BookId.Item1)
            {
                MessageBox.Show("Invalid Book ID");
                return;
            }
            if (!BorrowerId.Item1)
            {
                MessageBox.Show("Invalid Borrower ID");
                return;
            }

            Borrow = new Borrow()
            {
                BorrowId = Count,
                BookId = BookId.Item2,
                BorrowerId = BorrowerId.Item2,
                BorrowDate = DP_Date.DisplayDate
            };

            this.Close();
        }
    }
}
