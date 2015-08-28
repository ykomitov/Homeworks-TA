function solve() {

    function init(playerName, endCallback) {
        this.playerName = playerName;
        this.numberAsString = generateNumber();

        localStorage.setItem('playerName', this.playerName);
        localStorage.setItem('number', this.numberAsString);
        localStorage.setItem('numberOfGuesses', 0);

        // return this;
    }

    function guess(number) {
        var i,
            sheepCount = 0,
            ramCount = 0,
            numberAsArr = number.toString().split('') || undefined,
            originalNumAsStr = localStorage.getItem('number') || undefined,
            originalNumAsArr,
            result = {sheep: 0, rams: 0},
            currentHighScore = JSON.parse(localStorage.getItem('highScore')) || {},
            currentNumberOfGuesses = localStorage.getItem('numberOfGuesses') || 0;

        // Throw if init was not called before guess
        if (originalNumAsStr === undefined) {
            console.log('Game is not yet initialized!');
            throw new Error('Game is not yet initialized!');
        }

        originalNumAsArr = originalNumAsStr.split('');

        // Check for exact match & update high score
        if (number == originalNumAsStr) {
            currentNumberOfGuesses++;
            var player = localStorage.getItem('playerName');
            var isNewPlayer = JSON.stringify(currentHighScore).indexOf('player') < 0;

            if (isNewPlayer) {
                currentHighScore[player] = currentNumberOfGuesses;

                localStorage.setItem('highScore', JSON.stringify(currentHighScore));
                localStorage.setItem('number', undefined);
                console.log('success');
                return;
            } else {
                if (currentHighScore[player] >= currentNumberOfGuesses) {
                    console.log('success');
                    return;
                } else {
                    localStorage.setItem('highScore', JSON.stringify(currentHighScore));
                    localStorage.setItem('number', undefined);
                    console.log('success');
                    return;
                }
            }
        }

        // Initial check for 'rams'
        for (i = 0; i < 4; i += 1) {
            if (numberAsArr[i] === originalNumAsArr[i]) {
                ramCount++;
                originalNumAsArr[i] = 'x';
            }

            originalNumAsStr = originalNumAsArr.join('');
        }

        // Check for 'sheep'
        for (i = 0; i < 4; i += 1) {
            var positionInOriginalNumber = originalNumAsStr.indexOf(numberAsArr[i]);

            if (positionInOriginalNumber < 0) {
                continue;
            } else {
                sheepCount++;
                originalNumAsArr[positionInOriginalNumber] = 'x';
            }

            originalNumAsStr = originalNumAsArr.join('');
        }

        result.sheep = sheepCount;
        result.rams = ramCount;
        currentNumberOfGuesses++;
        localStorage.setItem('numberOfGuesses', currentNumberOfGuesses);

        return result;
    }

    function getHighScore(count) {
        // TODO: implement count!!!
        var sortable = [];
        var highScore = JSON.parse(localStorage.getItem('highScore'));

        for (var player in highScore) {
            sortable.push([player, highScore[player]]);
        }

        sortable.sort(function (a, b) {
            return a[1] - b[1]
        });

        console.log(sortable);

        for (var i = 0; i < sortable.length; i += 1) {
            console.log(i + 1 + ' - ' + sortable[i][0] + ': ' + sortable[i][1]);
        }
    }

    function generateNumber() {
        var a = getRandomInt(1, 9),
            b = getRandomInt(0, 9),
            c = getRandomInt(0, 9),
            d = getRandomInt(0, 9);

        var numberAsString = '' + a + b + c + d;

        return numberAsString;

        function getRandomInt(min, max) {
            return Math.floor(Math.random() * (max - min + 1)) + min;
        }
    }

    return {
        init, guess, getHighScore
    }
}


//module.exports = solve;
