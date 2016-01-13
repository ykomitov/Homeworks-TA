"use strict";

module.exports = function (Image) {

  let controller = {
    get: function (req, res) {
      Image.find({}, {}, function (err, images) {
        if (err) {
          throw err;
          //res.redirect('error');
        }

        res.render('images-all', {data: images})
      });
    },
    post: function (req, res) {
      let reqImage = req.body;

      if (!reqImage.image && req.file) {
        let fileName = req.file.path.substr(req.file.path.lastIndexOf('image-'));
        reqImage.image = '../images/' + fileName;
      }

      // Validate product

      let image = new Image({
        name: reqImage.name,
        description: reqImage.description,
        image: reqImage.image
      });

      image.save(function (err) {
        if (err) {
          throw err;
        }

        res
          .status(201)
          .redirect('/images/' + image._id);
      });
    },
    getForm: function (req, res) {
      // check if user is authenticated
      res.render('image-add');
      // else redirect to login or error
    },
    getById: function (req, res) {
      let id = req.params.id;
      Image.findById(id, function (err, image) {
        if (err) {
          throw err;
        }

        if (!image) {
          res.redirect('error-not-found');
          return;
        }

        res.render('image-details', {data: image});
      })
    }
  };

  return controller;
};