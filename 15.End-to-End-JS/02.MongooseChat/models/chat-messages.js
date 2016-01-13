'use strict';

let mongoose = require('mongoose');

let chatMessageSchema = new mongoose.Schema({
  from: {type: String, required: true},
  to: {type: String, required: true},
  text: {type: String, min: 2, max: 120, required: true}
});

let Message = mongoose.model('Message', chatMessageSchema);