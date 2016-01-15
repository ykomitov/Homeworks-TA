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
  app.get('/', function (req, res) {
    res.render('index');
  });

  // Event routes
  app.get('/events/create', auth.isAuthenticated, controllers.events.getCreate);
  app.post('/events/create', auth.isAuthenticated, controllers.events.postCreate);

  app.get('/events/active', controllers.events.getActive);

  // All other routes redirect to home page. IMPORTANT - must be the last route!!!
  app.get('*', function (req, res) {
    res.render('index');
  });
};