var pr3 = function () {
    var width,
        height;

    width = document.getElementById('problem3w').value;
    height = document.getElementById('problem3h').value;

    var area = width * height;

    console.log('The area of a rectangle with width ' + width + 'and height ' + height + 'is ' + area);

    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Input: rectangle with width ' + width + ' and height ' + height);
    jsConsole.writeLine('Area: ' + area);
    jsConsole.writeLine('=================================================');
}
