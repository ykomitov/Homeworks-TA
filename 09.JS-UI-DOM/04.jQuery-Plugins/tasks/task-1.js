function solve() {
    return function (selector) {
        var $selectInput = $(selector);
        var $select = $selectInput.clone().css('display', 'none');
        var $selectedOptions = $selectInput.children();
        var $divOptionsContainer = $('<div />')
            .addClass('options-container')
            .css({
                position: 'absolute',
                display: 'none'
            })
            .on('click', '.dropdown-item', function () {
                var $thisClicked = $(this);
                $divCurrent.html($thisClicked.html())
                    .attr('data-value', $thisClicked.attr('data-value'));
                $select.val($thisClicked.attr('data-value'));
                $divOptionsContainer.hide();
            });
        var $divCurrent = $('<div />')
            .addClass('current')
            .attr('data-value', '')
            .html('Option 1')
            .on('click', function () {
                $divCurrent.html('Select a value');
                $divOptionsContainer.show();
            });

        var len = $selectedOptions.length;
        for (var i = 0; i < len; i += 1) {
            var $internalDiv = $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', $($selectedOptions).eq(i).val())
                .attr('data-index', i)
                .html('Option ' + (i + 1));

            $divOptionsContainer.append($internalDiv);
        }

        var $outputDiv = $('<div />').addClass('dropdown-list');

        $outputDiv.append($select)
            .append($divCurrent)
            .append($divOptionsContainer);

        $selectInput.replaceWith($outputDiv);
    };
}

module.exports = solve;