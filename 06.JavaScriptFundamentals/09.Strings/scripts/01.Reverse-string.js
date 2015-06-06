var pr1 = function () {

    var webInput = document.getElementById('problem1').value,
        reversed = reverseStr(webInput);

    console.log('Input: ' + webInput);
    console.log('Reversed: ' + reversed);

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    jsConsole.writeLine('Input: ' + webInput);
    jsConsole.writeLine('Reversed: ' + reversed);
    jsConsole.writeLine('=================================================');

}

function reverseStr(str) {
    var input = str.split(''),
        output = '',
        i, len;

    len = input.length
    for (i = len - 1; i >= 0; i -= 1) {
        output += input[i];
    }

    return output;
}
