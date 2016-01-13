"use strict";

let express = require('express'),
  router = express.Router(),
  path = require('path'),
  data = require('./data'),
  http = require('http'),
  app = express();

// App setup
app.set('view engine', 'jade');
app.set('views', './views');

app.use("/css", express.static('./css'));

// Routes setup
router.get('/', function (req, res) {
  res.render('home', {title: 'Home'});
});

router.get('/phones', function (req, res) {
  res.render('devices', {title: 'Phones', data: data.Phones});
});
router.get('/tablets', function (req, res) {
  res.render('devices', {title: 'Tablets', data: data.Tablets});
});
router.get('/wearables', function (req, res) {
  res.render('devices', {title: 'Wearables', data: data.Wearables});
});

// Apply router
app.use('/', router);

let port = process.env.PORT || '6666';
app.listen(port, () => console.log(`Server running http://localhost:${port}`));