/* globals $ */

/* 

 Create a function that takes an id or DOM element and:


 */

function solve() {
    return function (selector) {
        var selectedByID,
            isDOMElement = checkIfObjectIsDOMElement(selector);

        //Validation starts

        if (!isDOMElement && typeof selector !== 'string') {
            throw new Error('The parameter is neither a string, nor a DOM element!');
        }

        if (!isDOMElement) {
            selectedByID = document.getElementById(selector);
            var childNodesInSelection = selectedByID.children;

            if (selectedByID === 'undefined' || selectedByID === null) {
                throw new Error('The provided ID does not select anything!');
            }
        }

        if (isDOMElement && !document.contains(selector)) {
            throw new Error('The provided DOM element is non-existent');
        }

        //Validation ends

        var elementsWithButtonClass = selectedByID.getElementsByClassName('button');

        var i, len = elementsWithButtonClass.length;
        for (i = 0; i < len; i += 1) {
            elementsWithButtonClass[i].innerHTML = 'hide';
            elementsWithButtonClass[i].addEventListener('click', clickEv, false);
        }

        function clickEv(ev) {

            var clickedNode = ev.target;
            var nextElement = clickedNode.nextElementSibling;

            while (nextElement.className !== 'content') {
                nextElement = nextElement.nextElementSibling;
            }

            if (nextElement.style.display !== 'none') {
                nextElement.style.display = 'none';
                clickedNode.innerHTML = 'show'
            } else {
                nextElement.style.display = '';
                clickedNode.innerHTML = 'hide'
            }
        }

        function checkIfObjectIsDOMElement(object) {
            if (object.tagName) {
                return true;
            }
        }
    };
}

module.exports = solve;