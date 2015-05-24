/**
 * Created by yzk on 5/22/15.
 */
function toggle_visible(className) {
    var e = document.getElementsByClassName(className)[0];
        e.style.display = 'block';
};

function toggle_hidden(className) {
    var e = document.getElementsByClassName(className)[0];
    e.style.display = 'none';
    jsConsole.clear();
};
