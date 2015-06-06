var pr3 = function () {
    var str = document.getElementById('problem3').value,
        key = document.getElementById('problem3w').value;

    console.log('Substring: ' + key);
    console.log('Count: ' + countSubstring(str, key));

    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Substring: ' + key);
    jsConsole.writeLine('Count: ' + countSubstring(str, key));
    jsConsole.writeLine('=================================================');
}

function countSubstring(string, key) {
    var substringArr = string.match(RegExp(key, 'ig'));
    return substringArr.length;
}