var pr2 = function () {

    var a,
        b,
        c;

    a = parseFloat(document.getElementById('problem2a').value);
    b = parseFloat(document.getElementById('problem2b').value);
    c = parseFloat(document.getElementById('problem2c').value);

    console.log('a = ' + a + ' b = ' + b + ' c = ' + c);
    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    jsConsole.writeLine('a = ' + a + ' b = ' + b + ' c = ' + c);

    if (a === 0 || b === 0 || c === 0) {
        console.log('0');
        jsConsole.writeLine('product is 0');
    }

    if (a > 0 && b > 0 && c > 0) {
        console.log('+');
        jsConsole.writeLine('product sign: +');
    }

    if (a < 0 && b < 0 && c > 0) {
        console.log('+');
        jsConsole.writeLine('product sign: +');
    }

    if (a < 0 && b > 0 && c < 0) {
        console.log('+');
        jsConsole.writeLine('product sign: +');
    }

    if (a > 0 && b < 0 && c < 0) {
        console.log('+');
        jsConsole.writeLine('product sign: +');
    }

    if (a < 0 && b < 0 && c < 0) {
        console.log('-');
        jsConsole.writeLine('product sign: -');
    }

    if (a > 0 && b < 0 && c > 0) {
        console.log('-');
        jsConsole.writeLine('product sign: -');
    }

    if (a < 0 && b > 0 && c > 0) {
        console.log('-');
        jsConsole.writeLine('product sign: -');
    }

    if (a > 0 && b > 0 && c < 0) {
        console.log('-');
        jsConsole.writeLine('product sign: -');
    }
    jsConsole.writeLine('=================================================');
}
