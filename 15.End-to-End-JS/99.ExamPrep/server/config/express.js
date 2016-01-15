var express = require('express'),
  bodyParser = require('body-parser'),
  cookieParser = require('cookie-parser'),
  session = require('express-session'),
  busboy = require('connect-busboy'),
  passport = require('passport');

module.exports = function (app, config) {

  // Jade settings
  app.set('view engine', 'jade');
  app.set('views', config.rootPath + '/server/views');

  // Body & cookie parser settings
  app.use(cookieParser());
  app.use(bodyParser.json());
  app.use(bodyParser.urlencoded({extended: true}));

  // Authentication related settings
  app.use(session({secret: 'magic unicorns', resave: true, saveUninitialized: true}));
  app.use(passport.initialize());
  app.use(passport.session());

  // Directory for static files, which are accessible on the server
  app.use(express.static(config.rootPath + '/public'));

  // Custom middleware for error handling - saves the error in the 'session' object, persistent after user refresh
  app.use(function (req, res, next) {
    if (req.session.error) {
      var msg = req.session.error;
      req.session.error = undefined;
      app.locals.errorMessage = msg;
    }
    else {
      app.locals.errorMessage = undefined;
    }

    next();
  });

  // Custom middleware for accessing user information in jade views
  app.use(function (req, res, next) {
    if (req.user) {
      app.locals.currentUser = req.user;
    }
    else {
      app.locals.currentUser = undefined;
    }

    next();
  });
};