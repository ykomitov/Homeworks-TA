var pr10 = function () {
    var input = document.getElementById('problem10').value;
    var out = findPalindromes(input);

    console.log(out);

    jsConsole.writeLine('<br>=================== Problem 10 ===================');
    jsConsole.writeLine(out);
    jsConsole.writeLine('=================================================');
}

function findPalindromes(str) {
    var input = str,
        lower = '',
        output = [],
        i, j, k, item, len, propLen;

    //make all letters lowercase
    for (i = 0, len = input.length; i < len; i += 1) {
        lower += input[i].toLowerCase();
    }

    //Remove all punctuation from the text and split it into an array, removing whitespaces
    lower = lower.replace(/['!"#$%&\\'()\*+,\-\.\/:;<=>?@\[\\\]\^_`{|}~']/g, ""); //remove all punctuation
    lower = lower.split(/\s*\b\s*/); //split into array of words


    for (i = 0, len = lower.length; i < len; i += 1) {
        for (j = 0, k = lower[i].length - 1, propLen = lower[i].length; j < propLen / 2; j += 1, k -= 1) {
            var isPalindrome = true;
            if (lower[i][j] === lower[i][k]) {
                continue;
            }
            else {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome) {
            output.push(lower[i]);
        }
    }

    return output;
}