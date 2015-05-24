var pr2 = function () {
    var input = document.getElementById('problem2').value,
        output;

    if (input % 5 === 0 && input % 7 === 0) {
        output = true;
    }
    else{
        output = false;
    }
    console.log(input + ' is dividable by both 5 & 7');
    console.log(output);

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    jsConsole.writeLine(input + ' is dividable by both 5 & 7');
    jsConsole.writeLine(output);
    jsConsole.writeLine('=================================================');
}
