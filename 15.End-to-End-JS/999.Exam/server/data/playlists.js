var Playlist = require('mongoose').model('Playlist'),
  constants = require('../common/constants');

module.exports = {
  create: function (playlist, username, callback) {

    if (constants.categories.indexOf(playlist.category) < 0) {
      callback('Invalid input!!!');
      return;
    }

    playlist.creator = username;
    playlist.creationDate = new Date();

    Playlist.create(playlist, callback);
  },
  getMostPopular: function (callback) {

    var numberOfPlaylistsToShow = 8;

    Playlist.find({})
      .where('isPrivate')
      .equals(false)
      .sort({rating: 'desc'})
      .limit(numberOfPlaylistsToShow)
      .exec(function (err, playlists) {
        var date = new Date();
        playlists.created = date;
        callback(err, playlists);
      });
  },
  getById: function (id, callback) {
    Playlist.findById(id, function (err, playlist) {
      if (err) {
        throw err;
      }

      if (!playlist) {
        callback(err);
        return;
      }

      callback(err, playlist);
    })
  },
  postById: function (id, url, callback) {
    Playlist.findById(id, function (err, playlist) {
      if (err) {
        throw err;
      }

      if (!playlist) {
        callback(err);
        return;
      }

      playlist.videoUrls.push(url);
      playlist.save();

      callback(err, playlist);
    })
  },
  getAll: function (page, sort, username, callback) {
    var page = page || 1;
    var pageSize = 10;
    var sortCriteria = {creationDate: 'desc'};

    if (sort === 'rating') {
      sortCriteria = {rating: 'desc'};
    }

    Playlist.find({$or: [{isPrivate: false}, {creator: username}]})
      .sort(sortCriteria)
      .limit(pageSize)
      .skip((page - 1) * pageSize)
      .exec(function (err, playlists) {
        if (err) {
          throw err;
        }

        Playlist.count()
          .exec(function (err, numberOfEvents) {
            var totalPages = Math.ceil(numberOfEvents / pageSize);
            var data = {
              playlists: playlists,
              currentPage: page,
              pageSize: pageSize,
              totalPages: totalPages
            };

            callback(err, data);
          })
      })
  },
  getByUsername: function (username, callback) {
    Playlist.find({$or: [{creator: username}]})
      .exec(function (err, playlists) {
        if (err) {
          throw err;
        }

        callback(err, playlists);
      })
  }
};