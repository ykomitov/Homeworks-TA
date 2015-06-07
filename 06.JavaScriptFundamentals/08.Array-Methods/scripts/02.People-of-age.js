var pr2 = function () {

    var personArr = makeArray();

    console.log('=== Problem 2 ===');
    console.log('Array contains only people of age: ' + personArr.every(ageGreaterThan18));

    jsConsole.writeLine('<br>=================== Problem 2 ===================');
    jsConsole.writeLine('Array contains only people of age: ' + personArr.every(ageGreaterThan18));
    jsConsole.writeLine('=================================================');

};


function ageGreaterThan18(object) {
    return object.age > 18;
}