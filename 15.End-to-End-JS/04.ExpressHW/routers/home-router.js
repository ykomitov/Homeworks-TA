"use strict";
let express = require('express');
let router = new express.Router();

let mongoose = require('mongoose');

let Image = mongoose.model('Image');
let controller = require('../controllers/home-controller')(Image);

router.get('/', controller.get);

module.exports = function (app) {
  app.use('/home', router);
};