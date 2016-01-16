var playlists = require('../data/playlists');

var cachedPlaylists = {
  created: 0
};

module.exports = {
  displayTopPlaylists: function (req, res) {

    // Check if the cached playlists are still valid
    var currentTime = new Date();
    var numberOfMinutes = 10;
    var mustUpdateCache;

    if (cachedPlaylists.created !== 0) {
      var currentTime = new Date(new Date().setMinutes(currentTime.getMinutes() - numberOfMinutes));
      mustUpdateCache = cachedPlaylists.created < currentTime;

      // Set numberOfMinutes to 1 and uncomment the following code to check caching

      //console.log(cachedPlaylists.created);
      //console.log(currentTime);
      //console.log(mustUpdateCache);
    }

    if (cachedPlaylists.created === 0 || mustUpdateCache) {
      playlists.getMostPopular(function (err, playlists) {
        console.log('Updating playlists from the server');
        cachedPlaylists = playlists;
        res.render('index', {playlists: playlists});
      });
    }
    else {
      console.log('Using cached playlists!');
      res.render('index', {playlists: cachedPlaylists});
    }
  }
};