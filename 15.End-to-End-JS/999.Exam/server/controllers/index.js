var UsersController = require('./UsersController'),
  HomeController = require('./HomeController'),
  PlaylistController = require('./PlaylistController');

module.exports = {
  home: HomeController,
  users: UsersController,
  playlists: PlaylistController
};