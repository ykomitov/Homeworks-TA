var pr6 = function () {
    var inputArr = [createPerson('Adam', 'Smith', 45),
        createPerson('Karl', 'Marx', 35),
        createPerson('Friedrich', 'von Hayek', 65),
        createPerson('Milton', 'Friedman', 40),
        createPerson('Milton', 'Davis', 40),
        createPerson('David', 'Ricardo', 40),
        createPerson('Joseph', 'Ricardo', 60),
        createPerson('John', 'Keynes', 20)];

    var testFirstName = groupPersons(inputArr, 'firstName');
    var testLastName = groupPersons(inputArr, 'lastName');
    var testAge = groupPersons(inputArr, 'age');

    var inStr = printPersons(inputArr);
    var gFirstName = printObj(testFirstName);

    console.log(inputArr);
    console.log(testFirstName);
    console.log(testLastName);
    console.log(testAge);

    jsConsole.writeLine('<br>=================== Problem 6 ===================');
    jsConsole.writeLine('Input: <br>' + inStr);
    jsConsole.writeLine('Grouped by First Name: <br>' + gFirstName);
    jsConsole.writeLine('Please check console for full associative arrays');
    jsConsole.writeLine('=================================================');
}

function groupPersons(arr, key) {
    var groupedArr = {},
        sortedArr,
        keyTemp,
        i,
        len;

    sortedArr = deepCopy(arr);
    switch (key) {
        case 'firstName':
            sortedArr.sort(function (p1, p2) {
                return p1.firstName > p2.firstName;
            });
            break;
        case 'lastName':
            sortedArr.sort(function (p1, p2) {
                return p1.lastName > p2.lastName;
            });
            break;
        case 'age':
            sortedArr.sort(function (p1, p2) {
                return p1.age > p2.age;
            });
            break;
        default:
            console.log('Invalid key');
            break;
    }

    keyTemp = sortedArr[0][key].toString();
    groupedArr[keyTemp] = [];

    for (i = 0, len = sortedArr.length; i < len; i += 1) {
        if (keyTemp === sortedArr[i][key].toString()) {
            groupedArr[keyTemp].push(sortedArr[i]);
        }
        else {
            keyTemp = sortedArr[i][key].toString();
            groupedArr[keyTemp] = [];
            groupedArr[keyTemp].push(sortedArr[i]);
        }
    }

    return groupedArr;
}

function printObj(obj) {
    var output = '',
        prop;

    for (prop in obj) {
        output += prop + '<br>';
    }

    return output;
}