var pr3 = function () {

    var input = {
        name: 'John', use: function () {
            console.log('Hi, my name is ' + this.name)
        }
    };
    var copy = deepCopy(input);
    copy.surname = 'Doe';

    var inStr = printObject(input);
    var outStr = printObject(copy);

    console.log(input);
    console.log(copy);
    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('Input: ' + inStr);
    jsConsole.writeLine('Output: ' + outStr);
    jsConsole.writeLine('=================================================');
}

function deepCopy(obj) {
    var copy,
        attr,
        i,
        len;

    // Handle the 3 simple types, and null or undefined
    if (null === obj || "object" !== typeof obj) return obj;

    // Handle Date
    if (obj instanceof Date) {
        copy = new Date();
        copy.setTime(obj.getTime());
        return copy;
    }

    // Handle Array
    if (obj instanceof Array) {
        copy = [];
        for (i = 0, len = obj.length; i < len; i += 1) {
            copy[i] = deepCopy(obj[i]);
        }
        return copy;
    }

    // Handle Object
    if (obj instanceof Object) {
        copy = {};
        for (attr in obj) {
            if (obj.hasOwnProperty(attr)) copy[attr] = deepCopy(obj[attr]);
        }
        return copy;
    }

    throw new Error("Unable to copy obj! Its type isn't supported.");
}

function printObject(obj) {
    var out = '{',
        len,
        count = 0,
        p;

    len = Object.keys(obj).length;

    for (p in obj) {
        out += p + ': ' + obj[p];

        if (count < len - 1) {
            count += 1;
            out += ', ';
        }
    }
    out += '}';
    return out;
}