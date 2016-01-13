"use strict";

module.exports = function (Image) {

  let controller = {
    get: function (req, res) {

      Image.find({}, {}, {
        skip: 0,
        limit: 10,
        sort: {
          date: -1
        }

      }, function (err, images) {
        let result = images;

        res.render('images-all', {data: result});
      });
    }
  };

  return controller;
};