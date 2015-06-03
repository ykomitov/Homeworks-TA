var pr1 = function () {

    var txtInput = document.getElementById('problem1').value;

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    console.log('Input: ' + txtInput);
    console.log('Last digit: ' + digitAsWord(txtInput));
    jsConsole.writeLine('Input: ' + txtInput);
    jsConsole.writeLine('Last digit: ' + digitAsWord(txtInput));
    jsConsole.writeLine('=================================================');
}

function digitAsWord(input) {
    var num,
        output = '';

    if (!(isNaN(input))) {
        num = (input * 1) | 0;

        switch (num % 10) {
            case 0:
                output += 'zero';
                break;
            case 1:
                output += 'one';
                break;
            case 2:
                output += 'two';
                break;
            case 3:
                output += 'three';
                break;
            case 4:
                output += 'four';
                break;
            case 5:
                output += 'five';
                break;
            case 6:
                output += 'six';
                break;
            case 7:
                output += 'seven';
                break;
            case 8:
                output += 'eight';
                break;
            case 9:
                output += 'nine';
                break;
            default:
                break;
        }
    }
    else {
        output = 'Not a number. Please input a number!';
    }
    return output;
}