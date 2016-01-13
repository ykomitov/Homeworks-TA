"use strict";

let express = require('express'),
  mongoose = require('mongoose'),
  bodyParser = require('body-parser'),
  path = require('path'),
  multer = require('multer');

require('./models');

// Multer config
var storage = multer.diskStorage({
  destination: function (req, file, cb) {
    cb(null, 'public/images')
  },
  filename: function (req, file, cb) {
    cb(null, file.fieldname + '-' + Date.now())
  }
});

let upload = multer({
  dest: 'public/images'
});

// Setup mongoose
let connectionString = "mongodb://localhost/it-gallery";
mongoose.connect(connectionString);

// Setup express
let app = express();
let port = process.env.PORT || 3001;

// Setup jade
app.set('view engine', 'jade');
app.set('views', './views');

// Setup body-parser
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));

app.use(express.static(path.join(__dirname, '/', 'public')));

// Setup router
require('./routers')(app, upload);

// Setup routes
app.get('/', function (req, res) {
  res.redirect('home');
});

app.listen(port, () => console.log(`App running at port ${port}`));