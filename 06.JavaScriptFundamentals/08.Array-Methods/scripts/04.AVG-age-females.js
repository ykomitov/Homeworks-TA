var pr4 = function () {

    var personArr = makeArray();
    var female = personArr.filter(isF);

    var avgAge = female.reduce(function (sum, obj) {
        return sum + obj.age;
    }, 0);

    console.log('AVG age of females: ' + avgAge / female.length);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('AVG age of females: ' + avgAge / female.length);
    jsConsole.writeLine('=================================================');
};

function isF(object) {
    return object.gender;
}
