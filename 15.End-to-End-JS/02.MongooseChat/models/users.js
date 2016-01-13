'use strict';

let mongoose = require('mongoose');

let userSchema = new mongoose.Schema({
  user: {type: String, required: true, unique: true},
  pass: {type: String, required: true}
});

let User = mongoose.model('User', userSchema);