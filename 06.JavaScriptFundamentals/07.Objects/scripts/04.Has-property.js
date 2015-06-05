var pr4 = function () {
    var input = {
        name: 'John', use: function () {
            console.log('Hi, my name is ' + this.name)
        }
    };

    var inStr = printObject(input);

    jsConsole.writeLine('<br>=================== Problem 4 ===================');
    jsConsole.writeLine('Input: ' + inStr);
    jsConsole.writeLine('Has property "age": ' + hasProperty(input, 'age'));
    jsConsole.writeLine('Has property "name": ' + hasProperty(input, 'name'));
    jsConsole.writeLine('=================================================');

    console.log(input);
    console.log('Has property "age": ' + hasProperty(input, 'age'));
    console.log('Has property "name": ' + hasProperty(input, 'name'));
}

function hasProperty(obj, prop) {
    var p;
    for (p in obj) {
        if (prop === p) {
            return true;
        }
    }
    return false;
}