var pr2 = function () {

    var arr1,
        arr2,
        counter = 0;

    arr1 = document.getElementById('problem21').value.split('');
    arr2 = document.getElementById('problem22').value.split('');

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    jsConsole.writeLine('array 1: ' + arr1.join(', '));
    jsConsole.writeLine('array 2: ' + arr2.join(', '));

    for (var i = 0; i < Math.min(arr1.length, arr2.length); i += 1) {
        if (arr1[i] < arr2[i]) {
            console.log('arr1 is lexicographically before arr2');
            jsConsole.writeLine('arr1 is lexicographically before arr2');
            break;
        }
        else if (arr1[i] > arr2[i]) {
            console.log('arr1 is lexicographically after arr2');
            jsConsole.writeLine('arr1 is lexicographically after arr2');
            break;
        }
        else {
            counter += 1;
            if (counter === Math.min(arr1.length, arr2.length)) {
                if (arr1.length < arr2.length) {
                    console.log('arr1 is lexicographically before arr2');
                    jsConsole.writeLine('arr1 is lexicographically before arr2');
                }
                else if (arr1.length > arr2.length) {
                    console.log('arr1 is lexicographically after arr2');
                    jsConsole.writeLine('arr1 is lexicographically after arr2');
                }
                else {
                    console.log('arr1 = arr2');
                    jsConsole.writeLine('arr1 = arr2');
                }
            }
        }
    }
    jsConsole.writeLine('=================================================');
}
