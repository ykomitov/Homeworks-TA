/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function solve(rangeStart, rangeEnd) {
    var i, j, maxDivisor,
        isPrime,
        outputArr = [];

    function checkForValidInput(a, b) {
        if (isNaN(a * 1) || isNaN(b * 1)) {
            throw new Error('All parameters must be convertible to numbers!');
        }

        if (a === undefined || b === undefined) {
            throw  new Error('The function requires two parameters!');
        }
    }

    checkForValidInput(rangeStart, rangeEnd);

    maxDivisor = Math.sqrt(rangeEnd * 1);
    for (i = rangeStart * 1; i <= rangeEnd * 1; i += 1) {
        isPrime = true;
        for (j = 2; j <= maxDivisor; j += 1) {
            if (i < 2) {
                isPrime = false;
                break;
            }

            if (i === 2) {
                break;
            }

            if (i % j === 0) {
                isPrime = false;
            }
        }

        if (isPrime) {
            outputArr.push(i);
        }
    }

    return outputArr;
}

module.exports = solve;