var pr9 = function () {
    var input = document.getElementById('problem9').value;
    var out = extractEmails(input);

    console.log(out);

    jsConsole.writeLine('<br>=================== Problem 9 ===================');
    jsConsole.writeLine(out);
    jsConsole.writeLine('=================================================');
}

function extractEmails(str) {
    var input = str,
        output;
    output = input.match(/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/g);

    return output;
}
