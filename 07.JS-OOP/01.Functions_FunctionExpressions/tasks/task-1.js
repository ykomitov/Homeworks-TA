/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function sum(params) {
    var sum, k, length;

    function checkForValidInput(params) {
        var i, len;

        if (params === undefined) {
            throw Error('Parameter is "undefined". Please define parameters!');
        }

        for (i = 0, len = params.length; i < len; i += 1) {
            if (isNaN(params[i] * 1)) {
                throw Error('One or more of the elements is not convertible to Number!');
            }
        }
    }

    checkForValidInput(params);

    if (params.length === 0) {
        return null;
    }
    else {
        sum = 0;
        for (k = 0, length = params.length; k < length; k += 1) {
            sum += params[k] * 1;
        }

        return sum;
    }
}

module.exports = sum;
