var pr2 = function () {

    var n,
        i,
        str = '';

    n = document.getElementById('problem2').value * 1;

    for (i = 1; i <= n; i += 1) {
        if (i % 3 === 0 && i % 7 === 0) {
            continue;
        }
        if (i < n) {
            str += i + ', ';
        }
        else {
            str += i;
        }
    }

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    console.log('N: ' + n);
    console.log(str);
    jsConsole.writeLine('N: ' + n);
    jsConsole.writeLine(str);
    jsConsole.writeLine('=================================================');
}
