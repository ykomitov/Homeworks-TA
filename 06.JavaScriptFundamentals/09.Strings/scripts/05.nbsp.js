var pr5 = function () {
    var test = 'I am        testing PR        N5!'
    console.log(test);
    console.log(nbsp(test));

    jsConsole.writeLine('<br>=================== Problem 5 ===================');
    jsConsole.writeLine(test);
    jsConsole.writeLine(nbsp(test));
    jsConsole.writeLine('=================================================');
}

function nbsp(str) {
    var output = str;
    while ((output.search(/ /)) >= 0) {
        output = output.replace(/ /, '&nbsp;');
    }
    return output;
}