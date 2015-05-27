var pr1 = function () {

    var n,
        i,
        str = '';

    n = document.getElementById('problem1').value * 1;

    for (i = 1; i <= n; i += 1) {
        if (i < n) {
            str += i + ', ';
        }
        else {
            str += i;
        }
    }

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    console.log('N: ' + n);
    console.log(str);
    jsConsole.writeLine('N: ' + n);
    jsConsole.writeLine(str);
    jsConsole.writeLine('=================================================');
}