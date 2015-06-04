var pr7 = function () {

    var arr = [1, 2, 3, 44, 55, 6, 6, 77, 8, 9],
        firstLargerIndex = firstLarger(arr);

    jsConsole.writeLine('<br>=================== Problem 7 ===================');
    jsConsole.writeLine('Array: ' + arr);
    jsConsole.writeLine('First larger than neighbours at index: ' + firstLargerIndex);
    console.log(arr);
    console.log('First larger than neighbours at index: ' + firstLargerIndex);
    jsConsole.writeLine('=================================================');
}

function firstLarger(array) {
    var i,
        len,
        firstLarger = -1,
        largerThanN;

    for (i = 0, len = array.length; i < len; i += 1) {
        largerThanN = largerThanNeighbours(array, i);

        if (largerThanN === 1) {
            firstLarger = i;
            break;
        }
    }
    return firstLarger;
}