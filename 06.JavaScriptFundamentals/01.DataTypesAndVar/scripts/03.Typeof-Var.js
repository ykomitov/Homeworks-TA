var pr3 = function pr3() {
    console.clear();

    console.log('============= Problem 3 =============');
    console.log(typeof intLiteral);
    console.log(typeof floatLiteral);
    console.log(typeof boolLiteral);
    console.log(typeof strLiteral);
    console.log(typeof pr2var);
    console.log('=====================================');

    jsConsole.writeLine('<br>=================== Problem 3 ===================');
    jsConsole.writeLine('intLiteral = 666; ===> '+typeof intLiteral);
    jsConsole.writeLine('floatLiteral = 1.234; ===> '+typeof floatLiteral);
    jsConsole.writeLine('boolLiteral = true; ===> '+typeof boolLiteral);
    jsConsole.writeLine("strLiteral = 'I am a string!'; ===> "+typeof strLiteral);
    jsConsole.writeLine("pr2var = `'How you doin'?', Joey said; ===> "+typeof pr2var);
    jsConsole.writeLine('=================================================');
};
