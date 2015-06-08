var pr1 = function () {

    //Input 1
    //var options = {name: 'John'};
    //'Hello, there! Are you #{name}?'.format(options);

    //Input 2
    //var options = {name: 'John', age: 13};
    //'My name is #{name} and I am #{age}-years-old'.format(options);

    //Input 3
    var options = {p1: 'idiot', p2: 'RegEx', p3: 'far better'};
    var out = 'I am an #{p1}, testing #{p2}. It is hard being an #{p1} and having a #{p2} homework! It would be #{p3} to start solving exam problems.'.format(options);

    jsConsole.writeLine('<br>=================== Problem 1 ===================');
    jsConsole.writeLine('Input: ' + "options = {p1: 'idiot', p2: 'RegEx', p3: 'far better'};");
    jsConsole.writeLine('I am an #{p1}, testing #{p2}. It is hard being an #{p1} and having a #{p2} homework! It would be #{p3} to start solving exam problems.');
    jsConsole.writeLine('Out: ' + out);
    jsConsole.writeLine('=================================================');
};

String.prototype.format = function (placeholderObj) {
    var inputStr = this.toString();
    var regex = inputStr.match(/#{\w+}/g);

    for (var i = 0; i < regex.length; i += 1) {
        var re = new RegExp(regex[i], 'g');
        var propertyName = regex[i].substring(2, regex[i].length - 1);
        inputStr = inputStr.replace(re, placeholderObj[propertyName]);
    }
    console.log(inputStr);
    return inputStr;
}
