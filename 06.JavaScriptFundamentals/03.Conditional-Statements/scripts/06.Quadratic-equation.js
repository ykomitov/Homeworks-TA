var pr6 = function () {

    var a,
        b,
        c,
        discriminant,
        root1,
        root2;

    a = parseFloat(document.getElementById('problem6a').value);
    b = parseFloat(document.getElementById('problem6b').value);
    c = parseFloat(document.getElementById('problem6c').value);
    discriminant = b * b - 4 * a * c;

    jsConsole.writeLine('<br>=================== Problem 6 ===================');
    if (a !== 1) {
        console.log('equation: ' + a + 'x^2 + ' + b + 'x + ' + c + ' = 0');
        jsConsole.writeLine('equation: ' + a + 'x² + ' + b + 'x + ' + c + ' = 0');
    }
    else{
        console.log('equation: x^2 + ' + b + 'x + ' + c + ' = 0');
        jsConsole.writeLine('equation: x² + ' + b + 'x + ' + c + ' = 0');
    }

    if (discriminant < 0) {
        console.log('no real roots');
        jsConsole.writeLine('no real roots');
    }
    else if (discriminant === 0) {
        root1 = root2 = (-b / (2 * a));
        console.log('root1 = root2 = ' + root1);
        jsConsole.writeLine('root1 = root2 = ' + root1);
    }
    else {
        root1 = ((-b - (Math.sqrt(discriminant))) / (2 * a));
        root2 = ((-b + (Math.sqrt(discriminant))) / (2 * a));
        console.log('root1 = ' + root1);
        console.log('root2 - ' + root2);
        jsConsole.writeLine('root1 = ' + root1);
        jsConsole.writeLine('root2 = ' + root2);
    }
    jsConsole.writeLine('=================================================');
}
