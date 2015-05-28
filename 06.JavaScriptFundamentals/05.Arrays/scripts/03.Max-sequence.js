var pr3 = function () {

    var seq,
        arr,
        min,
        max;

    seq = document.getElementById('problem3').value;
    arr = seq.split(",");
    min = arr[0] * 1;
    max = arr[1] * 1;

    for (var index in arr) {
        if (min > (arr[index] * 1)) {
            min = (arr[index] * 1);
        }
        if (max < (arr[index] * 1)) {
            max = (arr[index] * 1);
        }
    }

    console.log('Sequence: ' + seq);
    console.log('Min: ' + min);
    console.log('Max: ' + max);

    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Sequence: ' + seq);
    jsConsole.writeLine('Min: ' + min);
    jsConsole.writeLine('Max: ' + max);
    jsConsole.writeLine('=================================================');
}
