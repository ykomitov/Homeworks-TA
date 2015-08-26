/* 
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (books) {
        var authorsWithBookCount = _.chain(books)
            .groupBy(function (book) {
                return book.author.firstName + ' ' + book.author.lastName;
            })
            .mapObject(function (books) {
                return books.length;
            }).value();

        var maxBooks = _.max(authorsWithBookCount);

        var mostPopularAuthors = _.chain(authorsWithBookCount)
            .map(function (books, key) {
                if (books === maxBooks) {
                    return key;
                }
            })
            .reject(function (item) {
                return item === undefined;
            })
            .sortBy()
            .each(function (author) {
                console.log(author);
            });
    }
}

module.exports = solve;
