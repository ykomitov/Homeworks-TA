var pr5 = function () {
    var i,
        len,
        sampleArr = [1, 2, 3, 4, 4, 5, 5, 5, -1, -1, -1, -1],
        keys = [1, -1, 4, 5],
        expectedCount = [1, 4, 2, 3];

    jsConsole.writeLine('<br>=================== Problem 5 ===================');
    jsConsole.writeLine('Array: ' + sampleArr);
    console.log('Array: ' + sampleArr);

    for (i = 0, len = keys.length; i < len; i += 1) {

        console.log('Key: ' + keys[i]);
        console.log('Count in array: ' + appearanceCount(sampleArr, keys[i]));
        console.log('Test ' + (i + 1) + ': ' + (expectedCount[i] === appearanceCount(sampleArr, keys[i]) ? true : false));
        console.log('-----');

        jsConsole.writeLine('Key: ' + keys[i]);
        jsConsole.writeLine('Count in array: ' + appearanceCount(sampleArr, keys[i]));
        jsConsole.writeLine('Test ' + (i + 1) + ': ' + (expectedCount[i] === appearanceCount(sampleArr, keys[i]) ? true : false));
        jsConsole.writeLine('-----');
    }

    jsConsole.writeLine('=================================================');
}

function appearanceCount(arr, number) {

    var i,
        len,
        count = 0;

    for (i = 0, len = arr.length; i < len; i += 1) {
        if (arr[i] === number) {
            count += 1;
        }
    }

    return count;
}