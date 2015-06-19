/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {
        function Person(firstName, lastName, age) {
            validatePerson(firstName, lastName, age);
            this.firstname = firstName;
            this.lastname = lastName;
            this.age = age * 1;
        }

        function validatePerson(fName, lName, age) {

            if (typeof(fName) !== 'string' || typeof(lName) !== 'string') {
                throw new Error('FirstName & LastName must always be strings');
            }

            if (fName.length < 3 || fName.length > 20 || lName.length < 3 || lName.length > 20) {
                throw new Error('FirstName & LastName must have length between 3 and 20 characters');
            }

            if (isNaN(age * 1)) {
                throw new Error('Age must be a number!');
            } else {
                if (age * 1 < 0 || age * 1 > 150) {
                    throw new Error('Age must be between 0 and 150!');
                }
            }

            validateChars(fName);
            validateChars(lName);
        }

        function validateChars(name) {
            var i, len, charCode;

            for (i = 0, len = name.length; i < len; i += 1) {
                charCode = name.charCodeAt(i);
                if ((charCode < 65 && charCode > 90) && (charCode < 97 && charCode > 122)) {
                    throw new Error('Names can only contain Latin lower & uppercase letters');
                }
            }
        }

        return Person;
    }());

    Person.prototype = {
        get fullname() {
            return this.firstname + ' ' + this.lastname;
        },
        set fullname(fullname) {
            var firstN = fullname.split(' ')[0];
            var lastN = fullname.split(' ')[1];

            if (firstN.length < 3 || firstN.length > 20 || lastN.length < 3 || lastN.length > 20) {
                throw new Error('FirstName & LastName must have length between 3 and 20 characters');
            }

            var fullName = fullname.split(' ');
            this.firstname = fullName[0];
            this.lastname = fullName[1];
        }
    };

    Person.prototype.introduce = function () {
        return 'Hello! My name is ' + this.firstname + ' ' + this.lastname + ' and I am ' + this.age + '-years-old';
    };

    return Person;
}
module.exports = solve;

//function solve() {
//    var Person = (function () {
//        function Person(firstName, lastName, age) {
//            this.validatePerson(firstName, lastName, age);
//            this.firstname = firstName;
//            this.lastname = lastName;
//            this.age = age * 1;
//        }
//
//        return Person;
//    }());
//
//    Person.prototype.validatePerson = function(fName, lName, age) {
//
//        if (typeof(fName) !== 'string' || typeof(lName) !== 'string') {
//            throw new Error('FirstName & LastName must always be strings');
//        }
//
//        if (fName.length < 3 || fName.length > 20 || lName.length < 3 || lName.length > 20) {
//            throw new Error('FirstName & LastName must have length between 3 and 20 characters');
//        }
//
//        if (isNaN(age * 1)) {
//            throw new Error('Age must be a number!');
//        } else {
//            if (age * 1 < 0 || age * 1 > 150) {
//                throw new Error('Age must be between 0 and 150!');
//            }
//        }
//
//        this.validateChars(fName);
//        this.validateChars(lName);
//    };
//
//    Person.prototype.validateChars = function(name) {
//        var i, len, charCode;
//
//        for (i = 0, len = name.length; i < len; i += 1) {
//            charCode = name.charCodeAt(i);
//            if ((charCode < 65 && charCode > 90) && (charCode < 97 && charCode > 122)) {
//                throw new Error('Names can only contain Latin lower & uppercase letters');
//            }
//        }
//    };
//
//    Person.prototype.introduce = function () {
//        return 'Hello! My name is ' + this.firstname + ' ' + this.lastname + ' and I am ' + this.age + '-years-old';
//    };
//
//    Object.defineProperty(Person.prototype, 'fullname', {
//        get: function () {
//            return (this.firstname + ' ' + this.lastname);
//        },
//        set: function (fullname) {
//            this.validateChars(fullname);
//            var firstN = fullname.split(' ')[0];
//            var lastN = fullname.split(' ')[1];
//
//            if (firstN.length < 3 || firstN.length > 20 || lastN.length < 3 || lastN.length > 20) {
//                throw new Error('FirstName & LastName must have length between 3 and 20 characters');
//            }
//
//            var fullName = fullname.split(' ');
//            this.firstname = fullName[0];
//            this.lastname = fullName[1];
//        }
//    });
//    return Person;
//}