var pr4 = function () {

    var a,
        b,
        c,
        _1,
        _2,
        _3;

    a = parseFloat(document.getElementById('problem4a').value);
    b = parseFloat(document.getElementById('problem4b').value);
    c = parseFloat(document.getElementById('problem4c').value);

    console.log('a = ' + a + ' b = ' + b + ' c = ' + c);
    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('a = ' + a + ' b = ' + b + ' c = ' + c);

    if (a > Math.max(b, c)) {
        _1 = a;
        if (b > c) {
            _2 = b;
            _3 = c;
        }
        else {
            _2 = c;
            _3 = b;
        }
    }
    if (b > Math.max(a, c)) {
        _1 = b;
        if (a > c) {
            _2 = a;
            _3 = c;
        }
        else {
            _2 = c;
            _3 = a;
        }
    }
    if (c > Math.max(a, b)) {
        _1 = c;
        if (a > b) {
            _2 = a;
            _3 = b;
        }
        else {
            _2 = b;
            _3 = a;
        }
    }
    console.log('Sorted: ' + _1 + '; ' + _2 + '; ' + _3);
    jsConsole.writeLine('Sorted: ' + _1 + '; ' + _2 + '; ' + _3);
    jsConsole.writeLine('=================================================');
}
