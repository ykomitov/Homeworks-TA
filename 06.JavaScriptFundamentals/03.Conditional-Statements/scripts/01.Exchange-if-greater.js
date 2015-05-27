var pr1 = function () {

    var a,
        b,
        c;

    a = parseFloat(document.getElementById('problem1a').value);
    b = parseFloat(document.getElementById('problem1b').value);

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    console.log('initial: a = ' + a + '; b = ' + b);
    jsConsole.writeLine('initial: a = ' + a + '; b = ' + b);

    if (a > b) {
        c = a;
        a = b;
        b = c;

        console.log('exchanged: a = ' + a + '; b = ' + b);
        jsConsole.writeLine('exchanged: a = ' + a + '; b = ' + b);
        console.log(a + ' ' + b);
        jsConsole.writeLine(a + ' ' + b);
    }
    else {
        console.log('a is not greater than b');
        jsConsole.writeLine('a is not greater than b');
    }
    jsConsole.writeLine('=================================================');
}