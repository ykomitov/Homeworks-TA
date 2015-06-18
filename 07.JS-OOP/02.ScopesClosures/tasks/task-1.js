/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */


function solve() {

    var library = (function () {
        var books = [];
        var categories = [];

        function listBooks(optionsObject) {
            var booksList;

            if (optionsObject === undefined) {
                booksList = books;
            }

            else {
                if (optionsObject.hasOwnProperty('author')) {
                    booksList = books.filter(function (bookInLibrary) {
                        return bookInLibrary.author === optionsObject.author;
                    });
                }
                if (optionsObject.hasOwnProperty('category')) {
                    booksList = books.filter(function (bookInLibrary) {
                        return bookInLibrary.category === optionsObject.category;
                    });
                }
            }

            return booksList.sort(function (book1, book2) {
                return book1.ID > book2.ID;
            });
        }

        function addBook(book) {
            validateBook(book);
            validateCategory(book)

            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            var categoryKeys;
            categoryKeys = categories.sort(function (category1, category2) {
                return category1.ID > category2.ID;
            });

            return Object.keys(categoryKeys);
        }

        function validateCategory(book) {
            if (!(categories.some(function (categoryInArr) {
                    return categoryInArr === book.category;
                }))) {
                categories[book.category] = {'ID': categories.length + 1};
            }
        }

        function validateBook(book) {
            var i, j, bookArrLen, len;

            for (j = 0, bookArrLen = books.length; j < bookArrLen; j += 1) {
                if (books[j]['title'] === book.title) {
                    throw new Error('Book with the same title already exists');
                }

                if (books[j]['isbn'] === book.isbn) {
                    throw new Error('Book with the same isbn already exists');
                }
            }

            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('Book title must be between 2 and 100 characters');
            }

            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error('Book category name must be between 2 and 100 characters');
            }

            if (book.author.length === '') {
                throw new Error('Author must not be an empty string');
            }

            if (book.isbn.length !== 13 && book.isbn.length !== 10) {
                throw new Error('Book ISBN can only be 10 or 13 digits');
            }

            for (i = 0, len = book.isbn.length; i < len; i += 1) {
                if (isNaN(book.isbn[i])) {
                    throw new Error('Book ISBN can only contain digits');
                }
            }
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;
