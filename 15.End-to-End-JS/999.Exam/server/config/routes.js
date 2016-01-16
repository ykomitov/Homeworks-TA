var auth = require('./auth'),
  controllers = require('../controllers');

module.exports = function (app) {

  // Register & Login
  app.get('/register', controllers.users.getRegister);
  app.post('/register', controllers.users.postRegister);

  app.get('/login', controllers.users.getLogin);
  app.post('/login', auth.login);
  app.get('/logout', auth.logout);

  // Home page
  app.get('/', controllers.home.displayTopPlaylists);

  // Playlist routes
  app.get('/playlists/create', auth.isAuthenticated, controllers.playlists.getCreate);
  app.post('/playlists/create', auth.isAuthenticated, controllers.playlists.postCreate);
  app.get('/playlist/details/:id', auth.isAuthenticated, controllers.playlists.getPlaylistDetails);
  app.post('/playlist/details/:id', auth.isAuthenticated, controllers.playlists.uploadVideoLink);
  app.get('/playlists/all', auth.isAuthenticated, controllers.playlists.getAllPlaylists);
  app.get('/playlists/my', auth.isAuthenticated, controllers.playlists.getMyPlaylists);

  // Profile routes
  app.get('/profile', auth.isAuthenticated, controllers.users.getUpdate);
  app.post('/profile', auth.isAuthenticated, controllers.users.postUpdate);

  // All other routes redirect to home page. IMPORTANT - must be the last route!!!
  app.get('*', controllers.home.displayTopPlaylists);
};