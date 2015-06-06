var pr4 = function () {

    var str = document.getElementById('problem4').value;
    var formattedString = parseTags(str);

    console.log(replaceTags(formattedString));

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine(replaceTags(formattedString));
    jsConsole.writeLine('=================================================');

}

function parseTags(str) {
    var input = str.split(''),
        len = input.length,
        i,
        j,
        flagUpcase = false,
        flagLowcase = false,
        flagMixcase = false,
        tag = '';

    for (i = 0; i < len; i += 1) {
        if (input[i] === '<') {
            for (j = i; j < i + 10; j += 1) {
                while (input[j] !== '>') {
                    tag += input[j];
                    break;
                }
                if (input[j] === '>') {
                    tag += input[j];
                    break;
                }
            }

        }
        switch (tag) {
            case '<upcase>':
                flagUpcase = true;
                tag = '';
                break;
            case '</upcase>':
                flagUpcase = false;
                tag = '';
                break;
            case '<lowcase>':
                flagLowcase = true;
                tag = '';
                break;
            case '</lowcase>':
                flagLowcase = false;
                tag = '';
                break;
            case '<mixcase>':
                flagMixcase = true;
                tag = '';
                break;
            case '</mixcase>':
                flagMixcase = false;
                tag = '';
                break;
            default:
                break;
        }

        if (flagUpcase) {
            input[i] = input[i].toUpperCase();
        }

        if (flagLowcase) {
            input[i] = input[i].toLowerCase();
        }

        if (flagMixcase) {
            if (Math.random() > 0.5) {
                input[i] = input[i].toUpperCase();
            }
            else {
                input[i] = input[i].toLowerCase();
            }
        }
    }
    return input.join('');
}

function replaceTags(string) {
    var input = string;

    while ((input.search(/<lowcase>/i)) >= 0) {
        input = input.replace(/<lowcase>/i, '');
    }

    while ((input.search(/<\/lowcase>/i)) >= 0) {
        input = input.replace(/<\/lowcase>/i, '');
    }

    while ((input.search(/<upcase>/i)) >= 0) {
        input = input.replace(/<upcase>/i, '');
    }

    while ((input.search(/<\/upcase>/i)) >= 0) {
        input = input.replace(/<\/upcase>/i, '');
    }

    while ((input.search(/<mixcase>/i)) >= 0) {
        input = input.replace(/<mixcase>/i, '');
    }

    while ((input.search(/<\/mixcase>/i)) >= 0) {
        input = input.replace(/<\/mixcase>/i, '');
    }
    return input;
}