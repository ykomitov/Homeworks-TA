/* globals $ */

function solve() {

    return function (selector) {
        var template = '<div class="container">' +
            '<h1>Animals</h1>' +
            '<ul class="animals-list">' +
            '{{#animals}}' +
            '<li>' +
            '<a href="{{#if this.url}}{{this.url}}{{/if}}{{#unless this.url}}http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg{{/unless}}">' +
            '{{#if this.url}}See a {{this.name}}{{/if}}{{#unless this.url}}No link for {{this.name}} , here is Batman!{{/unless}}' +
            '</a></li>{{/animals}}</ul></div>';
        $(selector).html(template);
    };
}

module.exports = solve;