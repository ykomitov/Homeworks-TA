var pr5 = function () {
 var digit,
     digitAsWord;

    digit = parseFloat(document.getElementById('problem5').value);
    jsConsole.writeLine('<br>=================== Problem 5 ===================');

    switch (digit){
        case 0: digitAsWord = 'zero'; break;
        case 1: digitAsWord = 'one'; break;
        case 2: digitAsWord = 'two'; break;
        case 3: digitAsWord = 'three'; break;
        case 4: digitAsWord = 'four'; break;
        case 5: digitAsWord = 'five'; break;
        case 6: digitAsWord = 'six'; break;
        case 7: digitAsWord = 'seven'; break;
        case 8: digitAsWord = 'eight'; break;
        case 9: digitAsWord = 'nine'; break;
        default: digitAsWord = 'not a digit'; break;
    }

    console.log('Input: ' + digit);
    console.log(digitAsWord);
    jsConsole.writeLine('Input: ' + digit);
    jsConsole.writeLine(digitAsWord);
    jsConsole.writeLine('=================================================');
}
