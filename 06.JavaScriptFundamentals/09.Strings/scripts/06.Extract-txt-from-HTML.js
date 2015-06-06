var pr6 = function () {
    var input = document.getElementById('problem6').value;

    console.log(removeHtml(input));
    jsConsole.writeLine('<br>=================== Problem 6 ===================');
    jsConsole.writeLine(removeHtml(input));
    jsConsole.writeLine('=================================================');
}

function removeHtml(str) {
    var output = str;
    output = output.replace(/<(?:.|\n)*?>/gm, '');  //remove all HTML tags
    output = output.replace(/\n/gm, ' ');           //remove all new lines
    output = output.replace(/\s{2,}/g, ' ');        //remove all extra spaces
    return output.trim();
}