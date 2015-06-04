var pr6 = function () {
    var sampleArr = [1, 1, 3, 4, 1, 3, 4, 6, 3, 4, -1, 10, 11],
        index = 3,
        isLargerThanNeighbours = largerThanNeighbours(sampleArr, index);

    jsConsole.writeLine('<br>=================== Problem 6 ===================');
    jsConsole.writeLine('Array: ' + sampleArr);
    console.log(sampleArr);

    if (isLargerThanNeighbours === 1) {
        console.log(sampleArr[index] + ' at index ' + index + ' is larger than neighbours');
        jsConsole.writeLine(sampleArr[index] + ' at index ' + index + ' is larger than neighbours');
    }
    else if (isLargerThanNeighbours === 0) {
        console.log(sampleArr[index] + ' at index ' + index + ' is not larger than neighbours');
        jsConsole.writeLine(sampleArr[index] + ' at index ' + index + ' is not larger than neighbours');
    }
    else {
        console.log(isLargerThanNeighbours);
        jsConsole.writeLine(isLargerThanNeighbours);
    }

    jsConsole.writeLine('=================================================');
}

function largerThanNeighbours(arr, position) {
    var len = arr.length,
        isLarger;

    if ((position > (len - 1)) || (position < 0)) {
        isLarger = 'Index out or range!'
        return isLarger;
    }

    if (position === (len - 1)) {
        isLarger = arr[position] + ' at index ' + position + ' is the last element in the array';
    }
    else if (position === 0) {
        isLarger = arr[position] + ' at index ' + position + ' is the first element in the array';
    }
    else {
        if ((arr[position] > arr[position + 1]) && (arr[position] > arr[position - 1])) {
            isLarger = 1;
        }
        else {
            isLarger = 0;
        }
    }

    return isLarger;
}