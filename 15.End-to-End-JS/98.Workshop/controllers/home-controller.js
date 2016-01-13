"use strict";

module.exports = function (Product) {

  let controller = {
    get: function (req, res) {

      let query = {
        // name: { $or: ['Gosho', 'Pesho'] }
      };   // Filted by
      let selectedProperties = {}; // Properties to have

      Product.find(query, selectedProperties, {
        skip: 0,
        limit: 10,
        sort: {
          date: -1
        }

      }, function (err, products) {
        let result = products;

        //result.sort((pr1, pr2) => pr2._id.getTimestamp() - pr1._id.getTimestamp());
        //result = result.slice(0, 10);

        res.render('products-all', {data: result});
        //res.send(result);
      });
    }
  };

  return controller;
};