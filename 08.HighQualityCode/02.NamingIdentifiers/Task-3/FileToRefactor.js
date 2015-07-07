function onClick() {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName;

    if (browser === "Mozilla") {
        alert("Yes");
    } else {
        alert("No");
    }
}