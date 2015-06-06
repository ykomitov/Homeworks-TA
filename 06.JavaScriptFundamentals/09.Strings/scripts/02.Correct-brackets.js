var pr2 = function () {
    var str = document.getElementById('problem2').value;

    console.log('Expression: ' + str);
    console.log('Correct brackets: ' + checkBrackets(str));

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    jsConsole.writeLine('Expression: ' + str);
    jsConsole.writeLine('Correct brackets: ' + checkBrackets(str));
    jsConsole.writeLine('=================================================');
}

function checkBrackets(str) {
    var brackets = 0,
        inputStr = str.split(''),
        i, len,
        correctBrackets = true;

    for (i = 0, len = inputStr.length; i < len; i += 1) {
        if (brackets >= 0) {
            if (inputStr[i] === '(') {
                brackets += 1;
                //continue;
            }
            if (inputStr[i] === ')') {
                brackets -= 1;
            }
        }
        else {
            correctBrackets = false;
            break;
        }
    }

    if (brackets !== 0) {
        correctBrackets = false;
    }

    return correctBrackets;
}
