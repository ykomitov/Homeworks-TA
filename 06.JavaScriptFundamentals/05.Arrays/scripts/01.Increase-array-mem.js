var pr1 = function () {

    var arr1,
        i,
        output;

    arr1 = [];

    for (i = 0; i < 20; i += 1) {
        arr1[i] = i * 5;
    }

    output = arr1.join(', ');

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    console.log('Array length: ' + arr1.length);
    console.log('Array: ' + output);
    jsConsole.writeLine('Array length: ' + arr1.length);
    jsConsole.writeLine('Array: ' + output);
    jsConsole.writeLine('=================================================');
}