var pr5 = function () {

    var inputArr = [createPerson('Adam', 'Smith', 45), createPerson('Karl', 'Marx', 35), createPerson('Friedrich', 'von Hayek', 65)];
    var inStr = printPersons(inputArr);

    jsConsole.writeLine('<br>=================== Problem 5 ===================');
    jsConsole.writeLine('Input: <br>' + inStr);
    jsConsole.writeLine('Youngest person in array: ' + youngestPerson(inputArr).firstName + ' ' + youngestPerson(inputArr).lastName);
    jsConsole.writeLine('=================================================');

    console.log(inputArr);
    console.log('Youngest person in array: ' + youngestPerson(inputArr).firstName + ' ' + youngestPerson(inputArr).lastName);
}

function createPerson(firstname, lastname, age) {
    return {
        'firstName': firstname,
        'lastName': lastname,
        'age': age * 1
    }
}

function youngestPerson(personArr) {
    var sortedArr = deepCopy(personArr);
    sortedArr.sort(function (p1, p2) {
        return p1.age > p2.age;
    });
    return sortedArr[0];
}

function printPersons(arr) {
    var output = '',
        i, len;

    for (i = 0, len = arr.length; i < len; i += 1) {
        output += arr[i].firstName + ' ' + arr[i].lastName + ' age: ' + arr[i].age + '<br>';
    }

    return output;
}