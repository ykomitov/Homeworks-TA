/* globals $ */

/* 

 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {
    return function (selector, count) {
        var $selectedHTML, $ulToAppend, i;
        validateSelector(selector);
        validateCount(count);

        $selectedHTML = $(selector);
        $ulToAppend = $('<ul />').addClass('items-list');

        for (i = 0; i < count; i += 1) {
            var $liToAppend = $('<li />')
                .addClass('list-item')
                .html('List item #' + i);

            $ulToAppend.append($liToAppend);
        }

        $selectedHTML.append($ulToAppend);

        function validateCount(count) {
            if (count === undefined) {
                throw new Error('Count is missing!');
            }

            if (count < 1) {
                throw new Error('Count cannot be less than 1!')
            }

            if (typeof count !== 'number' && typeof count * 1 !== 'number') {
                throw new Error('Count is not convertible to number!')
            }
        }

        function validateSelector(selector) {
            if (typeof selector !== 'string') {
                throw new Error('Selector must be a string');
            }
        }
    };
}

module.exports = solve;