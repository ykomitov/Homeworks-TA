var pr7 = function () {
    var input = document.getElementById('problem7').value;

    console.log(parseUrl(input));
    jsConsole.writeLine('<br>=================== Problem 7 ===================');
    jsConsole.writeLine(printObject(parseUrl(input)));
    jsConsole.writeLine('=================================================');
}

function parseUrl(str) {
    var input = str,
        protocol,
        server,
        resource,
        separator = input.indexOf('://'),
        resourceStartIndex,
        output = {};

    protocol = input.substr(0, separator);
    output['protocol'] = protocol;

    server = input.substring((separator + 3), input.indexOf('/', (separator + 3)));
    output['server'] = server;

    resourceStartIndex = input.indexOf(server) + server.length;
    resource = input.substring(resourceStartIndex, input.length);
    output['resource'] = resource;

    return output;
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
            out += ', <br>';
        }
    }
    out += '}';
    return out;
}