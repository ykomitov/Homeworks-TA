"use strict";

module.exports = function (Product) {

  let controller = {
    get: function (req, res) {
      Product.find({}, {}, function (err, products) {
        if (err) {
          throw err;
          //res.redirect('error');
        }

        res.render('products-all', {data: products})
      });
    },
    post: function (req, res) {
      let reqProduct = req.body;

      if (!reqProduct.image && req.file) {
        reqProduct.image = req.file.path.substr('public/'.length);
      }

      // Validate product

      let product = new Product({
        name: reqProduct.name,
        description: reqProduct.description,
        price: +reqProduct.price,
        image: reqProduct.image
      });

      product.save(function (err) {
        res
          .status(201)
          .redirect('/products/' + product._id);
      });
    },
    getForm: function (req, res) {
      // check if user is authenticated
      res.render('product-add');
      // else redirect to login or error
    },
    getById: function (req, res) {
      let id = req.params.id;
      Product.findById(id, function (err, product) {
        if (err) {
          throw err;
        }

        if (!product) {
          res.redirect('error-not-found');
          return;
        }

        res.render('product-details', {data: product});
      })
    }
  };

  return controller;
};