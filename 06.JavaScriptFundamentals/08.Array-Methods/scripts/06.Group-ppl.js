var pr6 = function () {

    var personArr = makeArray();

    var grouped = personArr.reduce(function (grouped, person) {
        if (grouped[person.firstName[0]]) {
            grouped[person.firstName[0]].push(person);
        }
        else {
            grouped[person.firstName[0]] = [person];
        }

        return grouped;
    }, {});

    console.log(grouped);

    jsConsole.writeLine('<br>=================== Problem 6 ===================');
    jsConsole.writeLine('Please check the console...    ');
    jsConsole.writeLine('=================================================');
};