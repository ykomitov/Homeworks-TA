var pr4 = function () {
    var arr,
        counter_max = 1,
        counter_temp = 1,
        i,
        j,
        len,
        index,
        i_start,
        i_end,
        i_start_temp,
        sequence = '';

    arr = document.getElementById('problem4').value.split(',');

    //convert all elements of the array to numbers
    for (index in arr) {
        arr[index] = arr[index] * 1;
    }

    //find the max increasing sequence
    for (i = 0, len = arr.length, j = i + 1; i < len - 1; i += 1, j += 1) {

        if (arr[i] < arr[j]) {
            if (counter_temp === 1) {
                i_start_temp = i;
            }
            counter_temp += 1;
        }
        if (arr[i] >= arr[j]) {
            if (counter_max < counter_temp) {
                i_start = i_start_temp;
                i_end = j - 1;
                counter_max = counter_temp;
            }
            counter_temp = 1;
        }
        if (i === len - 2) {
            if (counter_max < counter_temp) {
                i_start = i_start_temp;
                i_end = j;
                counter_max = counter_temp;
            }
            counter_temp = 1;
        }
    }

    //print the longest increasing sequence
    for (i = i_start; i <= i_end; i += 1) {
        sequence += arr[i];
        if (i < i_end) {
            sequence += ', ';
        }
    }
    console.log(arr);
    console.log('Max increasing sequence: ' + sequence);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine(arr);
    jsConsole.writeLine('Max increasing sequence: ' + sequence);
    jsConsole.writeLine('=================================================');
}