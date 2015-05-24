var pr4 = function () {
    var input = document.getElementById('problem4').value,
        output;

    if (((input / 100) | 0) % 10 === 7) {
        output = true;
    }
    else {
        output = false;
    }

    console.log('The third digit of ' + input + ' (right-to-left) is 7: ' + output);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('Input: ' + input);
    jsConsole.writeLine('The third digit of ' + input + ' (right-to-left) is 7: ' + output);
    jsConsole.writeLine('=================================================');
}
