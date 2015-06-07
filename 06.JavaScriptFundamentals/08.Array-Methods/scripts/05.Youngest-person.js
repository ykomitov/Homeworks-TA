var pr5 = function () {

    var personArr = makeArray();
    personArr.sort(sortByAge);

    var youngestMale = personArr.find(function (obj) {
        return !(obj.gender);
    });

    console.log(personArr);
    console.log('Youngest male: ' + youngestMale.firstName + ' ' + youngestMale.lastName);

    jsConsole.writeLine('<br>=================== Problem 5 ===================');
    jsConsole.writeLine('Youngest male: ' + youngestMale.firstName + ' ' + youngestMale.lastName);
    jsConsole.writeLine('=================================================');

};

function sortByAge(obj1, obj2) {
    return obj1.age > obj2.age;
}