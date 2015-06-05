var pr2 = function () {

    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'],
        output;

    output = arr.removeElement(1); //arr = [2,4,3,4,111,3,2,'1'];

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    console.log('Input: ' + arr);
    console.log("Expected: [2,4,3,4,111,3,2,'1']");
    console.log('Output: ' + output);
    jsConsole.writeLine('Input: ' + arr);
    jsConsole.writeLine("Expected: 2,4,3,4,111,3,2,'1'");
    jsConsole.writeLine('Output: ' + output);
    jsConsole.writeLine('=================================================');
}

Array.prototype.removeElement = function (element) {

    var rElement = element,
        outputArr = [],
        i,
        len;

    for (i = 0, len = this.length; i < len; i += 1) {
        if (this[i] !== rElement) {
            outputArr.push(this[i]);
        }
    }

    return outputArr;
}
