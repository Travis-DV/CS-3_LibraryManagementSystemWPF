# Project 3 : Library Management WPF

## Requirements

> - [x] 1. Define Data Classes
>
>   - [x] Use the same Book, Borrower, and Borrow classes as in the console application.
>
> - [x] 2. Implement Data Storage
>
>   - [x] Use `ObservableCollection<Book>`, `ObservableCollection<Borrower>`, and `ObservableCollection<Borrow>` to store data in memory.
>   - [x] Populate these collections with sample data for testing.
>
> - [x] 3. Develop LINQ Queries
>
>   - [x] `ListBooks()`: Use query syntax to list all books.
>   - [x] `FindBorrowsByBorrower(int borrowerId)`: Use fluent syntax to find all borrows for a given borrower ID.
>   - [x] `CalculateTotalBorrows()`: Implement a subquery to calculate the total number of borrows for each borrower.
>
> - [x] 4. WPF Interface
>
>   - [x] Design the main window to include sections for displaying books, borrows, and total borrows.
>   - [x] Use controls such as ListView, DataGrid, TextBox, Button, and DatePicker to create the user interface.
>   - [x] Implement data binding to bind collections to UI controls.
>
> ## Instructions
>
> - [x] 1. Create a New WPF Project
>
>   - [x] Open Visual Studio and create a new WPF App (.NET Core) project named LibraryManagementSystemWPF.
>
> - [x] 2. Define Data Classes
>
>   - [x] Use the same Book, Borrower, and Borrow classes as defined in the console application.
>
> - [x] 3. Initialize Collections
>
>   - [x] `Create ObservableCollection<Book>`, `ObservableCollection<Borrower>`, and `ObservableCollection<Borrow>` to store data in memory.
>
> - [x] 4. Design the Main Window Layout
>
>   - [x] Use Grid and StackPanel to design the main window.
>
> - [x] 5. Implement Interaction Logic
>
>   - [x] Use AddBook_Click(object sender, RoutedEventArgs e) - The AddBook_Click method is an event handler that gets executed when the "Add Book" button is clicked in the WPF application. This method adds a new book to the Books collection with default or sample data.
>     - [x] 1. Creates a new instance of the Book class.
>     - [x] 2. Assigns values to the BookId, Title, Author, PublicationDate, and IsBorrowed properties.
>     - [x] 3. Adds the new book to the Books observable collection.
>     - [x] 4. The UI updates automatically to reflect the new book added due to the data binding with the Books collection.
>   - [x] Use AddBorrower_Click(object sender, RoutedEventArgs e) - The AddBorrower_Click method is an event handler that gets executed when the "Add Borrower" button is clicked in the WPF application. This method adds a new borrower to the Borrowers collection with default or sample data.
>     - [x] 1. Creates a new instance of the Borrower class.
>     - [x] 2. Assigns values to the BorrowerId, Name, Email, and DateOfMembership properties.
>     - [x] 3. Adds the new borrower to the Borrowers observable collection.
>     - [x] 4. The UI updates automatically to reflect the new borrower added due to the data binding with the Borrowers collection.
>   - [x] Use AddBorrow_Click(object sender, RoutedEventArgs e) - The AddBorrow_Click method is an event handler that gets executed when the "Add Borrow" button is clicked in the WPF application. This method adds a new borrow record to the Borrows collection with default or sample data, linking an existing book and borrower.
>     - [x] 1. Checks if there are any books and borrowers available.
>     - [x] 2. Creates a new instance of the Borrow class.
>     - [x] 3. Assigns values to the BorrowId, BookId, BorrowerId, and BorrowDate properties.
>     - [x] 4. Adds the new borrow record to the Borrows observable collection.
>     - [x] 5. The UI updates automatically to reflect the new borrow record added due to the data binding with the Borrows collection.
>   - [x] Use CalculateTotalBorrows_Click(object sender, RoutedEventArgs e) - The CalculateTotalBorrows_Click method is an event handler that gets executed when the "Calculate Total Borrows" button is clicked in the WPF application. This method calculates and displays the total number of borrows made by each borrower.
>     - [x] 1. Uses LINQ to join the Borrowers and Borrows collections.
>     - [x] 2. Groups the borrow records by BorrowerId and calculates the total number of borrows for each borrower.
>     - [x] 3. Builds a string with the results and assigns it to a TextBlock or Label to display the results in the UI.
