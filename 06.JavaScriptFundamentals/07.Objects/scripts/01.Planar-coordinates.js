var pr1points = function () {
    var p1arr = document.getElementById('pr1p1').value.split(','),
        p2arr = document.getElementById('pr1p2').value.split(',');

    //check input for consistency & define points
    if (checkPoint(p1arr)) {
        var point1 = createPoint((p1arr[0] * 1), (p1arr[1] * 1));
    }

    if (checkPoint(p2arr)) {
        var point2 = createPoint((p2arr[0] * 1), (p2arr[1] * 1));
    }

    //calculate the distance & print result
    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    console.log('P1: ' + p1arr);
    console.log('P2: ' + p2arr);
    console.log('Distance: ' + calcDistance(point1, point2));
    jsConsole.writeLine('P1: ' + p1arr);
    jsConsole.writeLine('P2: ' + p2arr);
    jsConsole.writeLine('Distance: ' + calcDistance(point1, point2));
    jsConsole.writeLine('=================================================');
}


var pr1lines = function () {
    var line1,
        line2,
        line3;

    var l1p1arr = document.getElementById('pr1line1p1').value.split(','),
        l1p2arr = document.getElementById('pr1line1p2').value.split(','),
        l2p1arr = document.getElementById('pr1line2p1').value.split(','),
        l2p2arr = document.getElementById('pr1line2p2').value.split(','),
        l3p1arr = document.getElementById('pr1line3p1').value.split(','),
        l3p2arr = document.getElementById('pr1line3p2').value.split(',');

    //check the input
    if (checkPoint(l1p1arr)) {
        var l1p1 = createPoint((l1p1arr[0] * 1), (l1p1arr[1] * 1));
    }

    if (checkPoint(l1p2arr)) {
        var l1p2 = createPoint((l1p2arr[0] * 1), (l1p2arr[1] * 1));
    }

    if (checkPoint(l2p1arr)) {
        var l2p1 = createPoint((l2p1arr[0] * 1), (l2p1arr[1] * 1));
    }

    if (checkPoint(l2p2arr)) {
        var l2p2 = createPoint((l2p2arr[0] * 1), (l2p2arr[1] * 1));
    }

    if (checkPoint(l3p1arr)) {
        var l3p1 = createPoint((l3p1arr[0] * 1), (l3p1arr[1] * 1));
    }

    if (checkPoint(l3p2arr)) {
        var l3p2 = createPoint((l3p2arr[0] * 1), (l3p2arr[1] * 1));
    }

    //create the 3 lines
    line1 = createLine(l1p1, l1p2);
    line2 = createLine(l2p1, l2p2);
    line3 = createLine(l3p1, l3p2);

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    if (line1.len + line2.len > line3.len &&
        line1.len + line3.len > line2.len &&
        line2.len + line3.len > line1.len) {

        console.log('The three segment lines can form a triangle');
        jsConsole.writeLine('The three segment lines can form a triangle');
    }
    else {
        console.log('The three segment lines cannot form a triangle');
        jsConsole.writeLine('The three segment lines cannot form a triangle');
    }
    jsConsole.writeLine('=================================================');
}

function checkPoint(arr) {
    var i,
        len;

    if (arr.length !== 2) {
        incorrectInput();
        return false;
    }

    for (i = 0, len = arr.length; i < len; i += 1) {
        if (isNaN(arr[i] * 1)) {
            incorrectInput();
            return false;
        }
    }
    return true;
}


function createPoint(x, y) {
    return {
        'x': x,
        'y': y
    };
}


function createLine(point1, point2) {
    return {
        'p1': point1,
        'p2': point2,
        'len': calcDistance(point1, point2)
    }
}


function calcDistance(point1, point2) {
    var distance = Math.sqrt(Math.pow((point2.x - point1.x), 2) + Math.pow((point2.y - point1.y), 2))
    return distance;
}


function incorrectInput() {
    console.log('Please enter correct coordinates for the points');
    jsConsole.writeLine('Please enter correct coordinates for the points');
    return;
}