"use strict";
let express = require('express');
let router = new express.Router();

let mongoose = require('mongoose');

let Image = mongoose.model('Image');
let controller = require('../controllers/images-controller')(Image);

module.exports = function (app, upload) {

  router.get('/', controller.get)
    .get('/add', controller.getForm)
    .get('/:id', controller.getById)
    .post('/', upload.single('image-file'), controller.post);

  app.use('/images', router);
};