'use strict';

let mongoose = require('mongoose');
let User = require('./models/users');
let Message = require('./models/chat-messages');

module.exports = function () {
  let mongoDbPath = 'mongodb://localhost:27017/mongooseChat';
  mongoose.connect(mongoDbPath);

// Get the connection
  let db = mongoose.connection;

// Event handler runs only once
  db.once('open', function () {
    console.log('Mongo is up and running!');
  });

// Event handler logs the error whenever it occurs
  db.on('error', function (err) {
    console.log(err);
  });
};