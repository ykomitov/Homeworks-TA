var pr3 = function () {

    var personArr = makeArray();
    var underAged = personArr.filter(ageLessThan18);


    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Underage:');
    underAged.forEach(printObjectFromArr);
    jsConsole.writeLine('=================================================');
};

function ageLessThan18(object) {
    return object.age < 18;
}

function printObjectFromArr(obj) {
    var output = '';
    output += obj.firstName + ' ' + obj.lastName + ' age: ' + obj.age;
    jsConsole.writeLine(obj.firstName + ' ' + obj.lastName + ' age: ' + obj.age);
    console.log(output);
}