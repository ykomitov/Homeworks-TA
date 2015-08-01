/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {

    return function (element, contents) {
        var selectedByID,
            isDOMElement = checkIfObjectIsDOMElement(element),
            i, len = contents.length,
            dFragment = document.createDocumentFragment();

        //Validation starts

        if (!isDOMElement && typeof element !== 'string') {
            throw new Error('First parameter is neither a string, nor a DOM element!');
        }

        if (!isDOMElement) {
            selectedByID = document.getElementById(element);

            if (selectedByID === 'undefined' || selectedByID === null) {
                throw new Error('The provided ID does not select anything!');
            }
        }

        if (!Array.isArray(contents)) {
            throw new Error('The second parameter must be an array!');
        }

        validateSecondParamContents(contents);

        //Validation ends

        var div = document.createElement('div');
        for (i = 0; i < len; i += 1) {
            var copy = div.cloneNode(true);
            copy.innerHTML = contents[i];
            dFragment.appendChild(copy);
        }

        if (isDOMElement) {
            element.innerHTML = '';
            element.appendChild(dFragment);
        }

        if (selectedByID) {
            selectedByID.innerHTML = '';
            selectedByID.appendChild(dFragment);
        }

        function checkIfObjectIsDOMElement(object) {
            if (object.tagName) {
                return true;
            }
        }

        function validateSecondParamContents(arr) {
            var i, len = arr.length;

            for (i = 0; i < len; i += 1) {
                if (typeof arr[i] !== 'string' && typeof  arr[i] !== 'number') {
                    throw  new Error('Parameter array may only contain strings or numbers!');
                }
            }
        }
    };
};