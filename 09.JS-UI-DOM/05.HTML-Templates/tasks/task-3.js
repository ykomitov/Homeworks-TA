function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this),
                template = $('#' + $this.attr('data-template')).html(),
                articleTemplate = handlebars.compile(template),
                i, len = data.length;

            for (i = 0; i < len; i += 1) {
                var dataToAppend = articleTemplate(data[i]);
                $this.append(dataToAppend);
            }

            return this;
        };
    };
}

module.exports = solve;