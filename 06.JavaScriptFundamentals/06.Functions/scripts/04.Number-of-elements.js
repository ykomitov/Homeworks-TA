var pr4 = function () {
    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('div count on current page: ' + countDivs());
    jsConsole.writeLine('=================================================');

    console.log('div count on current page: ' + countDivs());
}

function countDivs() {
    var collection,
        divCount;

    collection = document.getElementsByTagName('div');
    divCount = collection.length;

    return divCount;
}