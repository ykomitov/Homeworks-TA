/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName` and `age` properties
 *   Array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        var topStudent = _.chain(students)
            .map(function (student) {
                var sumOfMarks = _.reduce(student.marks, function (sum, mark) {
                    return sum + mark;
                }, 0);

                var countOfMarks = student.marks.length;
                student.avgMark = sumOfMarks / countOfMarks;
                return student;
            })
            .max(function (student) {
                return student.avgMark;
            })
            .value();

        //console.log(topStudent.firstName + ' ' + topStudent.lastName + ' has an average score of ' + topStudent.avgMark);
        var compiled = _.template("<% console.log(firstName + ' ' + lastName + ' has an average score of ' + avgMark); %>");
        compiled({
            firstName: topStudent.firstName,
            lastName: topStudent.lastName,
            avgMark: topStudent.avgMark
        });
    };
}

module.exports = solve;
