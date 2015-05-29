var pr6 = function () {
    var arr,
        counter_max = 1,
        counter_temp = 1,
        i,
        j,
        len,
        index,
        num;

    arr = document.getElementById('problem6').value.split(',');

    //convert all elements of the array to numbers
    for (index in arr) {
        arr[index] = arr[index] * 1;
    }

    //find the most frequent number
    for (i = 0, len = arr.length; i < len - 1; i += 1) {
        counter_temp = 1;
        for (j = i + 1; j < len; j += 1) {
            if (arr[i] === arr[j]) {
                counter_temp += 1;
            }
        }
        if (counter_max < counter_temp) {
            counter_max = counter_temp;
            num = arr[i];
        }
    }
    console.log(arr);
    console.log('Most frequent number: ' + num + ' (' + counter_max + ' times)');

    jsConsole.writeLine('<br>=================== Problem 6 ===================');
    jsConsole.writeLine(arr);
    jsConsole.writeLine('Most frequent number: ' + num + ' (' + counter_max + ' times)');
    jsConsole.writeLine('=================================================');
}