var pr3 = function () {

    var arr,
        num = undefined,
        counter_max = 1,
        counter_temp,
        i,
        j,
        len,
        index,
        max_sequence = '';

    arr = document.getElementById('problem3').value.split(',');

    for (index in arr) {
        arr[index] = arr[index] * 1;
    }

    for (i = 0, len = arr.length; i < len - 1; i += 1) {
        counter_temp = 1;
        for (j = i + 1; j < len; j += 1) {
            if (arr[i] === arr[j]) {
                counter_temp += 1;
            }
            else {
                break;
            }
        }
        if (counter_max < counter_temp) {
            num = arr[i];
            counter_max = counter_temp;
        }
    }

    for (i = 0; i < counter_max; i += 1) {
        max_sequence += num;
        if (i < counter_max - 1) {
            max_sequence += ', ';
        }
    }
    console.log(num);
    console.log(counter_max);

    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Array: ' + arr.join(', '));
    jsConsole.writeLine('Maximal sequence: ' + max_sequence);
    jsConsole.writeLine('=================================================');
}
