var pr5 = function () {
    var input = document.getElementById('problem5').value;
    var thirdBit = (input >> 3 & 1) === 1;

    if ((input | 0) !== parseFloat(input)) {
        console.log('Number is not an integer!');
        jsConsole.writeLine('Number is not an integer!');
        return;
    }

    console.log('Input: ' + input);
    console.log('Input as binary: ' + Number(input).toString(2));
    console.log('The bit #3 is ' + (thirdBit ? 1 : 0));

    jsConsole.writeLine('<br>=================== Problem 5 ===================');
    jsConsole.writeLine('Input: ' + input);
    jsConsole.writeLine('Input as binary: ' + Number(input).toString(2));
    jsConsole.writeLine('The bit #3 is ' + (thirdBit ? 1 : 0));
    jsConsole.writeLine('=================================================');
}
