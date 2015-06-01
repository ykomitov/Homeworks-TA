var pr7 = function () {
    var form,
        arr,
        key,
        i_min,
        i_max,
        i_mid,
        len,
        index,
        num;

    form = document.getElementById("pr7r");
    arr = form.elements['pr7r'].value.split(',');
    key = document.getElementById('problem7').value;

    //if key is present, convert to number
    if (key) {
        key *= 1;
    }

    //convert all elements of the array to numbers
    for (index in arr) {
        arr[index] = arr[index] * 1;
    }

    len = arr.length;
    i_min = 0;
    i_max = len - 1;

    console.log(arr);
    console.log(key);

    while (i_max >= i_min) {

        i_mid = (i_min + i_max) / 2 | 1;

        if (arr[i_mid] === key) {
            console.log('Key found at index ' + i_mid);
            return;
        }
        else if(i_min === i_max){
            console.log('Key found at index ' + i_min);
            return;
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
    }
}