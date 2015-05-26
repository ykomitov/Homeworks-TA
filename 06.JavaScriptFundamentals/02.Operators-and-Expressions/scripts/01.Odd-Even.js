var pr1 = function(){
    var input = 55,
        output;
    if (input % 2 === 0) {
        output = 'Number is even';
    }
    else {
        output = 'Number is odd';
    }
    console.log('input = ' + input);
    console.log(output);

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    jsConsole.writeLine('input = ' + input);
    jsConsole.writeLine(output);
    jsConsole.writeLine('=================================================');
}
