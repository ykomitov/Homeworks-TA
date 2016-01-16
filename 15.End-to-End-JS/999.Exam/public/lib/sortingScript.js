$('#sortBy').change(function () {
  var myURL = document.location.search;
  if ($(this).val() == 'creationDate') {
    document.location.search = myURL + "&sortBy=creationDate";
  }
  if ($(this).val() == 'rating') {
    document.location.search = myURL + "&sortBy=rating";
  }
});