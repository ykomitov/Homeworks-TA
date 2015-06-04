var pr2 = function () {

    var txtInput = document.getElementById('problem2').value;

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    console.log('Input: ' + txtInput);
    console.log('Reversed: ' + reverseNum(txtInput));
    jsConsole.writeLine('Input: ' + txtInput);
    jsConsole.writeLine('Reversed: ' + reverseNum(txtInput));
    jsConsole.writeLine('=================================================');
}

function reverseNum(input) {
    var num_orig,
        num_reversed = '',
        arr,
        len,
        i;

    if (!(isNaN(input))) {
        num_orig = input;

        arr = num_orig.split('');

        len = arr.length;

        for (i = len - 1; i >= 0; i -= 1) {
            num_reversed += arr[i];
        }
        num_reversed *= 1;
    }
    else {
        num_reversed = 'Not a number. Please input a number!';
    }
    return num_reversed;
}