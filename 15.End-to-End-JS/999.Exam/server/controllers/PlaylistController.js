var playlists = require('../data/playlists'),
  constants = require('../common/constants');

var CONTROLLER_NAME = 'playlists';

module.exports = {
  getCreate: function (req, res) {
    res.render(CONTROLLER_NAME + '/create', {categories: constants.categories});
  },
  postCreate: function (req, res) {
    var playlist = req.body,
      username = req.user.username;


    playlists.create(playlist, username, function (err, playlist) {
        if (err) {
          res.render(CONTROLLER_NAME + '/create', {errorMessage: err, categories: constants.categories});
          return;
        }
        console.log(playlist);
        res.redirect('/playlist/details/' + playlist._id);
      }
    )
  },
  getPlaylistDetails: function (req, res) {
    var id = req.params.id;

    playlists.getById(id, function (err, playlist) {
      res.render(CONTROLLER_NAME + '/playlistDetails', {playlist: playlist});
    });
  },
  uploadVideoLink: function (req, res) {
    var id = req.params.id;
    var url = req.body.youtubeLink;

    playlists.postById(id, url, function (err, updatedPlaylist) {
      res.render(CONTROLLER_NAME + '/playlistDetails', {playlist: updatedPlaylist});
    })
  },
  getAllPlaylists: function (req, res) {
    var page = req.query.page;
    var sort = req.query.sortBy;
    var username = req.user.username;
    playlists.getAll(page, sort, username, function (err, playlists) {
      res.render(CONTROLLER_NAME + '/allPlaylists', {data: playlists});
    })
  },
  getMyPlaylists: function (req, res) {
    var username = req.user.username;
    playlists.getByUsername(username, function (err, playlists) {
      res.render(CONTROLLER_NAME + '/myPlaylists', {playlists: playlists});
    })
  }
};