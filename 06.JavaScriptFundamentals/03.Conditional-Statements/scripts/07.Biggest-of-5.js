var pr7 = function () {

    var a,
        b,
        c,
        d,
        e,
        max,
        counter;

    a = document.getElementById('problem7a').value * 1;
    b = document.getElementById('problem7b').value * 1;
    c = document.getElementById('problem7c').value * 1;
    d = document.getElementById('problem7d').value * 1;
    e = document.getElementById('problem7e').value * 1;

    //assign only a number to MAX, otherwise leave it undefined
    if (!isNaN(a)) {
        max = a;
    }
    else {
        if (!isNaN(b)) {
            max = b;
        }
        else {
            if (!isNaN(c)) {
                max = c;
            }
            else {
                if (!isNaN(d)) {
                    max = d;
                }
                else {
                    if (!isNaN(e)) {
                        max = e;
                    }
                }
            }
        }
    }

    //nested if-else statements inside a loop. Loop is restarted if MAX value is changed
    for (counter = 0; counter < 1; counter += 1) {
        if (max < b) {
            max = b;
            counter -= 1;
        }
        else {
            if (max < c) {
                max = c;
                counter -= 1;
            }
            else {
                if (max < d) {
                    max = d;
                    counter -= 1;
                }
                else {
                    if (max < e) {
                        max = e;
                        counter -= 1;
                    }
                }
            }
        }
    }

    console.log('Input: a = ' + a + '; b = ' + b + '; c = ' + c + '; d = ' + d + '; e = ' + e);
    console.log('Max: ' + max);

    jsConsole.writeLine('<br>=================== Problem 7 ===================');
    jsConsole.writeLine('Input: a = ' + a + '; b = ' + b + '; c = ' + c + '; d = ' + d + '; e = ' + e);
    jsConsole.writeLine('Max: ' + max);
    jsConsole.writeLine('=================================================');
}
