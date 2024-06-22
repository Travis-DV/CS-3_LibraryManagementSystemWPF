using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


//INSTEAD OF A CALCULATE TOTAL BUTTON
//I just check every time it could change

namespace LibraryManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Book> Books = new ObservableCollection<Book>();
        public ObservableCollection<Borrower> Borrowers = new ObservableCollection<Borrower>();
        public ObservableCollection<Borrow> Borrows = new ObservableCollection<Borrow>();

        public MainWindow()
        {
            InitializeComponent();

            Books.Add(new Book()
            {
                BookId = Books.Count,
                Title = "Revenge of The Sith",
                Author = "George Lucas",
                PublicationDate = DateTime.Now,
                IsBorrowed = false,
            });
            Books.Add(new Book()
            {
                BookId = Books.Count,
                Title = "Harry Potter and the Goblet of Fire",
                Author = "J. K. Rowling",
                PublicationDate = DateTime.Now,
                IsBorrowed = false,
            });

            Borrowers.Add(new Borrower()
            {
                BorrowerId = Borrowers.Count,
                Name = "Test1",
                Email = "test1@test.com",
                DateOfMembership = DateTime.Now,
            });
            Borrowers.Add(new Borrower()
            {
                BorrowerId = Borrowers.Count,
                Name = "Test2",
                Email = "test2@test.com",
                DateOfMembership = DateTime.Now,
            });

            Borrows.Add(new Borrow()
            {
                BorrowId = Borrows.Count,
                BookId = 1,
                BorrowerId = 1,
                BorrowDate = DateTime.Now,
            });
            Borrows.Add(new Borrow()
            {
                BorrowId = Borrows.Count,
                BookId = 0,
                BorrowerId = 1,
                BorrowDate = DateTime.Now,
            });

            CalculateTotalBorrows();

            LV_Books.ItemsSource = Books;
            LV_Borrowers.ItemsSource = Borrowers;
            LV_Borrows.ItemsSource = Borrows;

        }

        private void FindBorrowsByBook(int bookId)
        {
            var borrowsByBorrower = Borrows.Where(borrow => borrow.BookId == bookId).ToList();
            LV_Borrows.ItemsSource = borrowsByBorrower;
        }

        private void Books_Clicked(object sender, MouseButtonEventArgs e)
        {
            FindBorrowsByBook(LV_Books.SelectedIndex);
        }

        private void FindBorrowsByBorrower(int borrowerId)
        {
            var borrowsByBorrower = Borrows.Where(borrow => borrow.BorrowerId == borrowerId).ToList();
            LV_Borrows.ItemsSource = borrowsByBorrower;
        }

        private void Borrowers_Clicked(object sender, MouseButtonEventArgs e)
        {
            FindBorrowsByBorrower(LV_Borrowers.SelectedIndex);
        }

        private void ListAll_Click(object sender, RoutedEventArgs e)
        {
            LV_Borrows.ItemsSource = Borrows;
        }

        private void NewBook_Click(object sender, RoutedEventArgs e)
        {
            NewBook newBook = new NewBook(Books.Count);
            newBook.ShowDialog();
            if (newBook != null)
            {
                Books.Add(newBook.Book);
            }
        }

        private void NewBorrower_Click(object sender, RoutedEventArgs e)
        {
            NewBorrower newBorrower = new NewBorrower(Books.Count);
            newBorrower.ShowDialog();
            if (newBorrower.Borrower != null)
            {
                Borrowers.Add(newBorrower.Borrower);
            }
        }

        private void NewBorrow_Click(object sender, RoutedEventArgs e)
        {
            NewBorrow newBorrow = new NewBorrow(Borrows.Count, Books.Count-1, Borrowers.Count-1);
            newBorrow.ShowDialog();
            if (newBorrow.Borrow != null)
            {
                Borrows.Add(newBorrow.Borrow);
                Books[newBorrow.Borrow.BookId].IsBorrowed = true;
            }
            
            LV_Books.ItemsSource = Borrows;
            LV_Books.ItemsSource = Books;

            CalculateTotalBorrows();
        }
        private void CalculateTotalBorrows()
        {
            /*
            var totalBorrowsPerBorrower = borrowers
                .Select(borrower => borrower.TotalBorrows = 
                    borrows.Count(borrow => borrow.BorrowerId == borrower.BorrowerId))
                .ToList();
            */
            foreach (Borrower borrower in Borrowers)
            {
                borrower.TotalBorrows = Borrows.Count(borrow => borrow.BorrowerId == borrower.BorrowerId);
            }
            LV_Borrowers.ItemsSource = Books;
            LV_Borrowers.ItemsSource = Borrowers;
        }
    }
}