var events = require('../data/events'),
  constants = require('../common/constants');

var CONTROLLER_NAME = 'events';

module.exports = {
  getCreate: function (req, res) {

    if (!req.user.phoneNumber) {
      //req.session.error = 'Sorry, you have to enter a phone number to create events!';
      //res.render(CONTROLLER_NAME + '/users/profile');
      // or
      //res.render(CONTROLLER_NAME + '/phone-required');
    }

    res.render(CONTROLLER_NAME + '/create', {
      categories: constants.categories,
      initiatives: constants.initiatives,
      seasons: constants.seasons
    });
  },
  postCreate: function (req, res) {
    var event = req.body;
    var user = {
      username: req.user.username,
      phoneNumber: req.user.phoneNumber
    };

    events.create(event, user, function (err, event) {
      if (err) {
        var data = {
          categories: constants.categories,
          initiatives: constants.initiatives,
          seasons: constants.seasons,
          errorMessage: err
        };

        res.render(CONTROLLER_NAME + '/create', data);
        return;
      }

      res.redirect('/events/details' + event._id);
    })
  },
  getActive: function (req, res) {
    var page = req.query.page;
    var pageSize = req.query.pageSize;

    events.active(page, pageSize, constants.initiatives, constants.seasons, function (err, data) {
      res.render(CONTROLLER_NAME + '/active', {data: data});
    })
  }
};