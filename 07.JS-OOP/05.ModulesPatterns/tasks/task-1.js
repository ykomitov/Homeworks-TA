/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var Course = {
        init: function (title, presentations) {
            validateTitle(title);
            validateTitle(presentations);

            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function (name) {
            var student = {};
            var studentNamesArr = validateStudentName(name);

            student.firstname = studentNamesArr[0];
            student.lastname = studentNamesArr[1];
            student.id = (this.students.length + 1);
            this.students.push(student);

            return this.students.length;
        },
        getAllStudents: function () {
            return this.students;
        },
        submitHomework: function (studentID, homeworkID) {
            validateStudentID(studentID, this.students);
            validateHomeworkID(homeworkID, this.presentations);
        },
        pushExamResults: function (results) {
        },
        getTopStudents: function () {
        }
    };

    function validateTitle(title) {
        var len = title.length, i;

        if (typeof title === 'string') {
            if (title[0] === ' ' ||
                title[len - 1] === ' ' ||
                title.indexOf('  ') > 0 ||
                title === '') {
                throw new Error('Invalid title!');
            }
        } else {
            if (len === 0) {
                throw new Error('There are no presentations in the course');
            }

            for (i = 0; i < len; i += 1) {
                validateTitle(title[i]);
            }
        }
    }

    function validateStudentName(name) {
        var namesArr = name.split(' '),
            firstName = namesArr[0],
            lastName = namesArr[1];

        function checkName(input) {
            var i, len = input.length;

            for (i = 1; i < len; i += 1) {
                if ((input.charCodeAt(i) < 97 || input.charCodeAt(i) > 122)) {
                    throw new Error('Names can contain only lowercase letters!');
                }
            }
        }

        if (namesArr.length > 2) {
            throw new Error('Student can only have 2 names!');
        }

        if ((firstName.charCodeAt(0) < 65 || firstName.charCodeAt(0) > 90) ||
            (lastName.charCodeAt(0) < 65 || lastName.charCodeAt(0) > 90)) {
            throw new Error('Names can only start with uppercase letter!');
        }

        checkName(firstName);
        checkName(lastName);

        return namesArr;
    }

    function validateHomeworkID(id, presentationsArr) {
        if (id < presentationsArr.length || id > presentationsArr.length) {
            throw new Error('Invalid presentation ID');
        }
    }

    function validateStudentID(id, studentsArr) {
        if (id < 1) {
            throw new Error('Student ID cannot be < 1');
        }
        if (id < studentsArr.length || id > studentsArr.length) {
            throw new Error('Invalid presentation ID');
        }
    }

    return Course;
}

module.exports = solve;
