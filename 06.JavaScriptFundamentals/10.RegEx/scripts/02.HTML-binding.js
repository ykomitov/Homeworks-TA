var pr2 = function () {

    //var str = '<div data-bind-content="name"></div>';
    //str.bind(str, {name: 'Steven'});

    var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';
    var newStr = str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    jsConsole.writeLine('Binding done. Please check console for output...');
    jsConsole.writeLine('=================================================');
}

String.prototype.bind = function (str, obj) {
    var inputStr = str,
        divIndex, aIndexName, aIndexLink, outputStr;

    if (Object.keys(obj).length === 1) {
        divIndex = inputStr.match(/<\/div>/).index;
        outputStr = str.substr(0, divIndex) + obj['name'] + str.substring(divIndex);
    }
    if (Object.keys(obj).length === 2) {
        aIndexName = inputStr.match(/<\/a>/).index;
        aIndexLink = aIndexName - 1;
        outputStr = str.substr(0, aIndexLink) + ' href="' + obj['link'] + '"' + ' class="' + obj['name'] + '"' + str.substring(aIndexLink);
        aIndexName = outputStr.match(/<\/a>/).index;
        outputStr = outputStr.substr(0, aIndexName) + obj['name'] + outputStr.substring(aIndexName);
    }

    console.log(outputStr);
    return outputStr;
}
