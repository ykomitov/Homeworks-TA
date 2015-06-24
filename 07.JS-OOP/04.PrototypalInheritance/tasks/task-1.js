/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 > property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 > property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 > property content of type string
 * sets the content of the element
 * works only if there are no children
 > property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 > property children
 * each child is a domElement or a string
 > property parent
 * parent is a domElement
 > method appendChild(domElement / string)
 * appends to the end of children list
 > method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {
        var domElement = {

            init: function (type) {
                validateType(type);
                this.type = type;
                this.children = [];
                this.attributes = [];
                this.content = '';

                return this;
            },
            appendChild: function (child) {
                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {
                var tempAttribute = [],
                    i, len, containsName = false;

                validateAttribute(name, value);

                for (i = 0, len = this.attributes.length; i < len; i += 1) {
                    if (this.attributes[i][0] === name) {
                        containsName = true;
                        this.attributes[i][1] = value;
                    }
                }

                if (!containsName) {
                    tempAttribute.push(name);
                    tempAttribute.push(value);
                    this.attributes.push(tempAttribute);
                }

                return this;
            },
            get innerHTML() {
                var orderedAttributesString = '',
                    appendedChildrenString = '',
                    contentString = '',
                    orderedAttributesArr, i, len;

                orderedAttributesArr = this.attributes.sort(function (a, b) {
                    return a[0] > b[0];
                });

                for (i = 0, len = orderedAttributesArr.length; i < len; i += 1) {
                    orderedAttributesString += ' ' + orderedAttributesArr[i][0] + '="' + orderedAttributesArr[i][1] + '"';
                }

                for (i = 0, len = this.children.length; i < len; i += 1) {
                    if (typeof(this.children[i]) === 'string') {
                        appendedChildrenString += this.children[i];
                    } else {
                        appendedChildrenString += this.children[i].innerHTML;
                    }
                }

                if (this.content && this.children.length === 0) {
                    contentString += this.content;
                }

                return '<' + this.type + orderedAttributesString + '>' + appendedChildrenString + contentString + '</' + this.type + '>';
            }
        };

        return domElement;
    }());

    function validateType(input) {
        var i, len, charCode;

        if ((typeof input !== 'string') || (input.length < 1)) {
            throw new Error('A valid type is any non-empty string');
        }

        for (i = 0, len = input.length; i < len; i += 1) {
            charCode = input.charCodeAt(i);

            if ((charCode < 65 || charCode > 90) && (charCode < 97 || charCode > 122) && (charCode < 48 || charCode > 57)) {
                throw new Error('A valid type contains only Latin letters and digits');
            }
        }
    }

    function validateAttribute(name, value) {
        var i, len = name.length, charCode;

        if (!name && len < 1) {
            throw new Error('Each attribute must have a name');
        }

        for (i = 0; i < len; i += 1) {
            charCode = name.charCodeAt(i);

            if ((charCode < 65 || charCode > 90) && (charCode < 97 || charCode > 122) && (charCode < 48 || charCode > 57) && (charCode !== 45)) {
                throw new Error('A valid attribute name contains only Latin letters and digits or dashes (-)');
            }
        }

        //if (!value) {
        //    throw new Error('Each attribute must have a value');
        //}
    }

    return domElement;
}

module.exports = solve;

