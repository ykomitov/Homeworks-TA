var pr3 = function () {
    var txt,
        word,
        type,
        result;

    txt = document.getElementById('problem3').value;
    word = document.getElementById('problem3w').value;
    type = document.querySelector('input[name="pr3"]:checked').value;

    //function overloading
    if (!!(type*1)) {
        result = countWord(txt, word, type);
    }
    else{
        result = countWord(txt, word);
    }

    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Word: ' + word);
    jsConsole.writeLine('Count: ' + result);
    jsConsole.writeLine('Case sensitive: ' + !!(type*1));
    jsConsole.writeLine('=================================================');

    console.log('Word: ' + word);
    console.log('Count: ' + result);
    console.log('Case sensitive: ' + !!(type*1));
}

function countWord(txtInput, word, caseSensitive) {

    var txtArr,
        key = word,
        counter = 0,
        len,
        i;

    //Remove all punctuation from the text and split it into an array, removing whitespaces
    txtArr = txtInput.replace(/['!"#$%&\\'()\*+,\-\.\/:;<=>?@\[\\\]\^_`{|}~']/g, ""); //remove all punctuation
    txtArr = txtArr.split(/\s*\b\s*/); //split into array of words

    //selector for function overloading
    switch (arguments.length) {
        case 3:
            break;
        case 2:
            for (i = 0, len = txtArr.length; i < len; i += 1) {
                txtArr[i] = txtArr[i].toLowerCase();
            }
            key = key.toLowerCase();
            break;
    }

    for (i = 0, len = txtArr.length; i < len; i += 1) {
        if (key === txtArr[i]) {
            counter += 1;
        }
    }

    return counter;
}