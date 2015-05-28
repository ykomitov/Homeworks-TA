var pr4document = function () {

    var prop,
        lex_min = document[0],
        lex_max = document[0],
        i = 0;

    for (prop in document) {
        if (i === 0) {
            lex_min = prop;
            i += 1;
        }
        if (i === 1) {
            lex_max = prop;
            i += 1;
        }
        if (i > 1) {
            if (lex_min > prop) {
                lex_min = prop;
            }
            if (lex_max < prop) {
                lex_max = prop;
            }
        }
    }

    console.log('In document:');
    console.log('Lexicographically smallest property: ' + lex_min);
    console.log('Lexicographically largest property: ' + lex_max);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('In document:');
    jsConsole.writeLine('Lexicographically smallest property: ' + lex_min);
    jsConsole.writeLine('Lexicographically largest property: ' + lex_max);
    jsConsole.writeLine('=================================================');
}

var pr4window = function () {

    var prop,
        lex_min = window[0],
        lex_max = window[0],
        i = 0;

    for (prop in window) {
        if (i === 0) {
            lex_min = prop;
            i += 1;
        }
        if (i === 1) {
            lex_max = prop;
            i += 1;
        }
        if (i > 1) {
            if (lex_min > prop) {
                lex_min = prop;
            }
            if (lex_max < prop) {
                lex_max = prop;
            }
        }
    }

    console.log('In window:');
    console.log('Lexicographically smallest property: ' + lex_min);
    console.log('Lexicographically largest property: ' + lex_max);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('In window:');
    jsConsole.writeLine('Lexicographically smallest property: ' + lex_min);
    jsConsole.writeLine('Lexicographically largest property: ' + lex_max);
    jsConsole.writeLine('=================================================');
}

var pr4navigator = function () {

    var prop,
        lex_min = navigator[0],
        lex_max = navigator[0],
        i = 0;

    for (prop in navigator) {
        if (i === 0) {
            lex_min = prop;
            i += 1;
        }
        if (i === 1) {
            lex_max = prop;
            i += 1;
        }
        if (i > 1) {
            if (lex_min > prop) {
                lex_min = prop;
            }
            if (lex_max < prop) {
                lex_max = prop;
            }
        }
    }

    console.log('In navigator:');
    console.log('Lexicographically smallest property: ' + lex_min);
    console.log('Lexicographically largest property: ' + lex_max);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('In navigator:');
    jsConsole.writeLine('Lexicographically smallest property: ' + lex_min);
    jsConsole.writeLine('Lexicographically largest property: ' + lex_max);
    jsConsole.writeLine('=================================================');
}