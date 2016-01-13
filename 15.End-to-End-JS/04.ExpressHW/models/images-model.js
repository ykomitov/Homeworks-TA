"use strict";

let mongoose = require('mongoose');
let imagesSchema = new mongoose.Schema({
  name: {type: String, required: true},
  date: {
    type: Date,
    requred: true,
    default: function () {
      return Date.now()
    }
  },
  image: {type: String},
  description: String
});

mongoose.model('Image', imagesSchema);