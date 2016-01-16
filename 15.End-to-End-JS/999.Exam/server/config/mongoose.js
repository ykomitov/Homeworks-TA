var mongoose = require('mongoose'),
  UserModel = require('../data/models/User'),
  PlaylistModel = require('../data/models/Playlist');

module.exports = function (config) {
  mongoose.connect(config.db);
  var db = mongoose.connection;

  db.once('open', function (err) {
    if (err) {
      console.log('Database could not be opened: ' + err);
      return;
    }

    console.log('Database up and running...')
  });

  db.on('error', function (err) {
    console.log('Database error: ' + err);
  });

  UserModel.init();
  PlaylistModel.init();

  // Can generate sample data with loops here! TODO: Uncomment if you need sample data in the DB!
  //var Playlist = require('mongoose').model('Playlist');
  //var User = require('mongoose').model('User');
  //
  //for (var i = 1; i < 11; i += 1) {
  //  var wannabePlaylist = {
  //    title: 'Playlist ' + i,
  //    description: 'Sample description ' + i,
  //    videoUrls: ['#video1', '#video2'],
  //    category: 'Jazz',
  //    creator: 'user' + i,
  //    creationDate: new Date(),
  //    isPrivate: false,
  //    rating: i
  //  };
  //
  //  var wannabeUser = {
  //    username: 'user' + i,
  //    firstName: 'user' + i + ' FirstName',
  //    lastName: 'user' + i + ' LastName',
  //    email: 'user' + i + '@user.com'
  //  };
  //
  //  var newPlaylist = new Playlist(wannabePlaylist);
  //  newPlaylist.save(function (err) {
  //    if (err) {
  //      console.log(err);
  //    }
  //    else {
  //      console.log('Playlist created!');
  //    }
  //  });
  //
  //  var newUser = new User(wannabeUser);
  //  newUser.save(function (err) {
  //    if (err) {
  //      console.log(err);
  //    }
  //    else {
  //      console.log('User created!');
  //    }
  //  })
  //}
};