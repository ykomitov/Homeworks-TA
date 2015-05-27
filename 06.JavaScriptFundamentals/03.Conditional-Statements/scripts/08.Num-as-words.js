var pr8 = function () {
    var number,
        hundreds = '',
        tens = '',
        ones = '',
        teens = '',
        digitAsWord = '';

    String.prototype.capitalize = function() {
        return this.charAt(0).toUpperCase() + this.slice(1);
    }

    number = parseInt(document.getElementById('problem8').value);

    if (number >= 0 && number < 1000) {
        if (number === 0) {
            ones += 'zero'
        }

        switch ((number / 100) | 0) {
            case 0:
                break;
            case 1:
                hundreds += 'one hundred';
                break;
            case 2:
                hundreds += 'two hundred';
                break;
            case 3:
                hundreds += 'three hundred';
                break;
            case 4:
                hundreds += 'four hundred';
                break;
            case 5:
                hundreds += 'five hundred';
                break;
            case 6:
                hundreds += 'six hundred';
                break;
            case 7:
                hundreds += 'seven hundred';
                break;
            case 8:
                hundreds += 'eight hundred';
                break;
            case 9:
                hundreds += 'nine hundred';
                break;
            default:
                break;
        }

        switch (((number / 10) | 0) % 10) {
            case 0:
                break;
            case 1:
                break;
            case 2:
                tens += 'twenty';
                break;
            case 3:
                tens += 'thirty';
                break;
            case 4:
                tens += 'forty';
                break;
            case 5:
                tens += 'fifty';
                break;
            case 6:
                tens += 'sixty';
                break;
            case 7:
                tens += 'seventy';
                break;
            case 8:
                tens += 'eighty';
                break;
            case 9:
                tens += 'ninety';
                break;
            default:
                break;
        }

        switch (number % 10) {
            case 0:
                break;
            case 1:
                ones += 'one';
                break;
            case 2:
                ones += 'two';
                break;
            case 3:
                ones += 'three';
                break;
            case 4:
                ones += 'four';
                break;
            case 5:
                ones += 'five';
                break;
            case 6:
                ones += 'six';
                break;
            case 7:
                ones += 'seven';
                break;
            case 8:
                ones += 'eight';
                break;
            case 9:
                ones += 'nine';
                break;
            default:
                break;
        }

        if (number % 100 >= 10 && number % 100 < 20) {
            ones = '';
            switch (number % 100) {
                case 10:
                    teens += 'ten';
                    break;
                case 11:
                    teens += 'eleven';
                    break;
                case 12:
                    teens += 'twelve';
                    break;
                case 13:
                    teens += 'thirteen';
                    break;
                case 14:
                    teens += 'fourteen';
                    break;
                case 15:
                    teens += 'fifteen';
                    break;
                case 16:
                    teens += 'sixteen';
                    break;
                case 17:
                    teens += 'seventeen';
                    break;
                case 18:
                    teens += 'eighteen';
                    break;
                case 19:
                    teens += 'nineteen';
                    break;
                default:
                    break;
            }
        }

        if (hundreds.length > 1 && (ones.length > 1 || teens.length > 1)) {
            digitAsWord = hundreds + ' and ' + tens + ' ' + ones + ' ' + teens;
        }
        else if (hundreds.length > 1 && ones.length < 1 && teens.length < 1 && tens.length > 1) {
            digitAsWord = hundreds + ' and ' + tens;
        }
        else {
            digitAsWord = hundreds + ' ' + tens + ' ' + ones + ' ' + teens;
        }

        //trim & capitalize the resulting string
        digitAsWord = digitAsWord.trim().capitalize();

        console.log('Input: ' + number);
        console.log(digitAsWord);
    }
    else {
        console.log('Invalid input');
    }


    jsConsole.writeLine('<br>=================== Problem 8 ===================');
    jsConsole.writeLine('Input: ' + number);
    jsConsole.writeLine(digitAsWord);
    jsConsole.writeLine('=================================================');

}