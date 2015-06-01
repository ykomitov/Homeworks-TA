var pr7 = function () {
    var form,
        arr,
        key,
        i_min,
        i_max,
        i_mid,
        len,
        index;

    form = document.getElementById("pr7r");
    arr = form.elements['pr7r'].value.split(','); //get the array from selected radio button
    key = document.getElementById('problem7').value; //get the key from the text input

    jsConsole.writeLine('<br>=================== Problem 7 ===================');
    //if key is present, convert to number
    if (key) {
        key *= 1;

        //convert all elements of the array to numbers
        for (index in arr) {
            arr[index] = arr[index] * 1;
        }

        len = arr.length;
        i_min = 0;
        i_max = len - 1;

        console.log('Original array:');
        console.log(arr);
        console.log('Key: ' + key);
        jsConsole.writeLine('Input array: ' + arr);
        jsConsole.writeLine('Key: ' + key);

        //search for the key using binary search algorithm
        while (i_max >= i_min) {

            if (isNaN(key)) {
                console.log('Search key is not a number!');
                jsConsole.writeLine('Search key is not a number!');
                break;
            }

            if (!(i_min) && !(i_max)) {
                i_mid = 0;
            }
            else {
                i_mid = (i_min + i_max) / 2 | 0;
            }

            if (arr[i_mid] === key) {
                console.log('Key found at index ' + i_mid);
                jsConsole.writeLine('Key found at index ' + i_mid);
                break;
            }
            else if (arr[i_mid] < key) {
                i_min = i_mid + 1;
            }
            else {
                i_max = i_mid - 1;
            }
        }

        if (i_max < i_min) {
            console.log('Key not found');
            jsConsole.writeLine('Key not found');
        }
    }
    else {
        console.log('Please enter search key!');
        jsConsole.writeLine('Please enter search key!');
    }
    jsConsole.writeLine('=================================================');
}