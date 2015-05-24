var pr8 = function () {
    var a,
        b,
        h,
        area;

    a = parseFloat(document.getElementById('problem8a').value);
    b = parseFloat(document.getElementById('problem8b').value);
    h = parseFloat(document.getElementById('problem8h').value);
    area = ((a + b) / 2) * h;

    console.log('Input: a = ' + a + ' ; b = ' + b + ' ; h = ' + h);
    console.log('Area: ' + area);

    jsConsole.writeLine('<br>=================== Problem 7 ===================');
    jsConsole.writeLine('Input: a = ' + a + ' ; b = ' + b + ' ; h = ' + h);
    jsConsole.writeLine('Area: ' + area);
    jsConsole.writeLine('=================================================');
}
