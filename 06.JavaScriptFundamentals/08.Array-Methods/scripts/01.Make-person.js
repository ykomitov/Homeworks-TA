var pr1 = function () {

    var personArr = makeArray();

    console.log('=== Problem 1 ===');
    console.log(personArr);

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    jsConsole.writeLine(printPersons(personArr));
    jsConsole.writeLine('=================================================');
};

function createPerson(firstname, lastname, age, gender) {
    return {
        'firstName': firstname,
        'lastName': lastname,
        'age': age * 1,
        'gender': gender
    }
}

function makeArray() {
    var array = [createPerson('Apostol', 'Bakalov', 25, false),
        createPerson('Vladislav', 'Ivanov', 27, false),
        createPerson('Ilina', 'Konsulova', 12, true),
        createPerson('Stoyan', 'Stoyanov', 16, false),
        createPerson('Valentina', 'Zheliyazkova', 21, true),
        createPerson('Alena', 'Glushkova', 23, true),
        createPerson('Angel', 'Stoyanov', 33, false),
        createPerson('Liliya', 'Rasheva', 29, true),
        createPerson('Veselin', 'Petkov', 20, false),
        createPerson('Liliya', 'Stoycheva', 19, true)]

    return array;
}

function printPersons(arr) {
    var output = '',
        i, len;

    for (i = 0, len = arr.length; i < len; i += 1) {
        output += arr[i].firstName + ' ' + arr[i].lastName + ' age: ' + arr[i].age + '<br>';
    }

    return output;
}