var pr7 = function(){
    var input = document.getElementById('problem7').value;
    var isPrime = true;

    for (var i = 2; i < input; i+=1){
        if(input % i === 0){
            isPrime = false;
            break;
        }
    }
    console.log('Input: ' + input);
    console.log('Is prime: ' + isPrime);

    jsConsole.writeLine('<br>=================== Problem 7 ===================');
    jsConsole.writeLine('Input: ' + input);
    jsConsole.writeLine('Is prime: ' + isPrime);
    jsConsole.writeLine('=================================================');
}
