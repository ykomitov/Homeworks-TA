var pr3 = function () {

    var a,
        b,
        c;

    a = parseFloat(document.getElementById('problem3a').value);
    b = parseFloat(document.getElementById('problem3b').value);
    c = parseFloat(document.getElementById('problem3c').value);

    console.log('a = ' + a + ' b = ' + b + ' c = ' + c);
    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('a = ' + a + ' b = ' + b + ' c = ' + c);

    if (a > b) {
        if (b > c || b === c) {
            console.log('biggest: ' + a);
            jsConsole.writeLine('biggest: ' + a);
        }
        if (b < c) {
            if (a > c) {
                console.log('biggest: ' + a);
                jsConsole.writeLine('biggest: ' + a);
            }
            if (a < c) {
                console.log('biggest: ' + c);
                jsConsole.writeLine('biggest: ' + c);
            }
            if (a === c) {
                console.log('a = c = ' + a + ' both > b');
                jsConsole.writeLine('a = c = ' + a + ' both > b');
            }
        }
    }
    else if (b > a) {
        if (a > c || a === c) {
            console.log('biggest: ' + b);
            jsConsole.writeLine('biggest: ' + b);
        }
        if (a < c) {
            if (b > c) {
                console.log('biggest: ' + b);
                jsConsole.writeLine('biggest: ' + b);
            }
            if (b < c) {
                console.log('biggest: ' + c);
                jsConsole.writeLine('biggest: ' + c);
            }
            if (b === c) {
                console.log('b = c = ' + b + ' both > a');
                jsConsole.writeLine('b = c = ' + b + ' both > a');
            }
        }
    }
    else if (a === b) {
        if (a > c) {
            console.log('a = b = ' + a + ' both > c');
            jsConsole.writeLine('a = b = ' + a + ' both > c');
        }
        if (a === c) {
            console.log('all numbers are equal');
            jsConsole.writeLine('all numbers are equal');
        }
    }
    jsConsole.writeLine('=================================================');
}
