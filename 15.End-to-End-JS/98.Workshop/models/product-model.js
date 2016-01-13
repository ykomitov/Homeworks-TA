"use strict";

let mongoose = require('mongoose');
let productSchema = new mongoose.Schema({
  name: {type: String, required: true},
  date: {
    type: Date, requred: true, default: function () {
      return Date.now()
    }
  },
  image: {type: String},
  description: String,
  price: Number
});

mongoose.model('Product', productSchema);