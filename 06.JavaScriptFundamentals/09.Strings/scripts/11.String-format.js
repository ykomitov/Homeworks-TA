var pr11 = function () {

    var frmt = '{3} {0}, {1}, {0} text {2}';
    var str = stringFormat(frmt, 1, 'Pesho', [1, 2], true);

    // var str = stringFormat('Hello {0}!', 'Peter');

    console.log(str);

    jsConsole.writeLine('<br>=================== Problem 11 ===================');
    jsConsole.writeLine('Input: ');
    jsConsole.writeLine("frmt = '{3} {0}, {1}, {0} text {2}';");
    jsConsole.writeLine("str = stringFormat(frmt, 1, 'Pesho', [1, 2], true);");
    jsConsole.writeLine('<br>Output: ' + str);
    jsConsole.writeLine('=================================================');
}

function stringFormat(string, input1, input2, input3, input4, input5, input6, input7, input8, input9, input10, input11, input12, input13, input14, input15, input16, input17, input18, input19, input20, input21, input22, input23, input24, input25, input26, input27, input28, input29, input30) {
    var input = string,
        argumentsArr = [],
        i, len;

    for (i = 1, len = arguments.length; i < len; i += 1) {
        argumentsArr.push(arguments[i]);
    }

    for (i = 0, len = arguments.length; i < len; i += 1) {
        var regex = new RegExp('\\{' + i + '\\}', 'g');
        input = input.replace(regex, argumentsArr[i]);
    }

    return input;
}
