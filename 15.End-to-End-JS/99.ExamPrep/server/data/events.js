var Event = require('mongoose').model('Event'),
  constants = require('../common/constants');

module.exports = {
  create: function (event, user, callback) {
    if (constants.categories.indexOf(event.category) < 0
      || constants.initiatives.indexOf(event.initiative) < 0
      || constants.seasons.indexOf(event.season) < 0) {
      callback('Invalid input!!!');
      return;
    }
    else {
      event.type = {
        initiative: event.initiative,
        season: event.season
      }
    }

    event.creator = user.username;
    event.phoneNumber = user.phoneNumber;
    event.date = new Date();
    event.date.setDate(event.date.getDate() + 30);

    if (event.latitude && event.longitude) {
      event.location = {
        latitude: event.latitude,
        longitude: event.longitude
      }
    }

    Event.create(event, callback);
  },
  active: function (page, pageSize, initiatives, seasons, callback) {
    page = page || 1;
    pageSize = pageSize || 10;

    Event
      .find({})
      .where('type.initiative')
      .in(initiatives)
      .where('type.season')
      .in(seasons)
      .sort({date: 'desc'})
      .limit(pageSize)
      .skip((page - 1) * pageSize)
      .exec(function (err, foundEvents) {
        if (err) {
          callback(err);
          return;
        }

        Event.count()
          .exec(function (err, numberOfEvents) {

            var totalPages = Math.ceil(numberOfEvents / pageSize);

            callback(err, {
              events: foundEvents,
              currentPage: page,
              pageSize: pageSize,
              totalPages: totalPages
            })
          });

      })

  }
};