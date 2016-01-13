"use strict";

let express = require('express'),
  mongoose = require('mongoose'),
  bodyParser = require('body-parser'),
  path = require('path'),
  multer = require('multer');

// Setup mongoose
let connectionString = "mongodb://localhost/images-gallery";
mongoose.connect(connectionString);

require('./models');

// Setup express
let app = express();
let port = process.env.PORT || 3001;

// Setup body-parser
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));

app.use(express.static(path.join(__dirname, '/', 'public')));

// Setup jade
app.set('view engine', 'jade');
app.set('views', './views');

// Multer config
var storage = multer.diskStorage({
  destination: './public/images',
  filename: function (req, file, cb) {

    let ext = file.originalname
      .split('.')
      .pop();
    cb(null, file.fieldname + '-' + Date.now() + '.' + ext);
  }
});

var upload = multer({
  storage: storage
});

// Setup router
require('./routers')(app, upload);

// Setup routes
app.get('/', function (req, res) {
  res.render('home');
});

app.listen(port, () => console.log(`App running at port ${port}`));