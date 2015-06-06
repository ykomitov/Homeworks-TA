var pr12 = function () {

    var source = [
            {name: 'Peter', age: 14},
            {name: 'Gosho', age: 15},
            {name: 'Pesho', age: 16}],

        template = '<strong>-{name}-</strong> <span>-{age}-</span>',
        ul = document.createElement('ul'),
        li, item;

    for (item in source) {
        li = document.createElement('li');
        li.innerHTML = format(template, source[item]);
        ul.appendChild(li);
    }
    document.getElementById("prob12").appendChild(ul);

    jsConsole.writeLine('<br>=================== Problem 12 ===================');
    jsConsole.writeLine('The ul should appear in the end of the page');
    jsConsole.writeLine('=================================================');
}

function format(string, person) {
    return string.replace(/\-{(\w+)\}-/g, function (regex, property) {
        return person[property] || '';
    });
}