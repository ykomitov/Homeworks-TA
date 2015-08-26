/* 
 Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **finds** and **prints** the total number of legs to the console in the format:
 *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (animals) {
        var totalNumberOfLegs = _.reduce(animals, function (sum, animal) {
            return sum + animal.legsCount;
        }, 0);

        var compiled = _.template("<% console.log('Total number of legs: ' + numberOfLegs); %>");
        compiled({numberOfLegs: totalNumberOfLegs});
    };
}

module.exports = solve;
