var pr5 = function () {
    var arr_unsorted,
        arr_sorted = [],
        i,
        j,
        len,
        index,
        i_min_index;

    arr_unsorted = document.getElementById('problem5').value.split(',');

    //convert all elements of the array to numbers
    for (index in arr_unsorted) {
        arr_unsorted[index] = arr_unsorted[index] * 1;
    }

    console.log('Original array:');
    console.log(arr_unsorted);
    jsConsole.writeLine('<br>=================== Problem 5 ===================');
    jsConsole.writeLine('Array 1: ' + arr_unsorted);

    //perform selection sort algorithm - replace sorted element with Number.MAX_VALUE;
    for (i = 0, len = arr_unsorted.length; i < len; i += 1) {
        j = 0;
        i_min_index = 0;
        while (j < len) {
            if (arr_unsorted[i_min_index] > arr_unsorted[j]) {
                i_min_index = j;
            }
            j += 1;
        }
        //populate arr_sorted
        arr_sorted.push(arr_unsorted[i_min_index]);
        arr_unsorted[i_min_index] = Number.MAX_VALUE;
    }

    console.log('Sorted array:');
    console.log(arr_sorted);
    jsConsole.writeLine('Array 2: ' + arr_sorted);
    jsConsole.writeLine('=================================================');
}