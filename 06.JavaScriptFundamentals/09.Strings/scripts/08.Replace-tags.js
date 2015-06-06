var pr8 = function () {
    var input = document.getElementById('problem8').value;

    console.log(replaseATag(input));
    jsConsole.writeLine('<br>=================== Problem 8 ===================');
    jsConsole.writeLine(replaseATag(input));
    jsConsole.writeLine('=================================================');
}

function replaseATag(str) {
    var output = str;
    output = output.replace(/<a href="/gm, '[URL=');
    output = output.replace(/">/gm, ']');
    output = output.replace(/<\/a>/g, '[/URL]');
    return output.trim();
}