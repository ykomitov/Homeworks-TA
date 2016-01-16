var User = require('mongoose').model('User');

module.exports = {
  create: function (user, callback) {
    User.create(user, callback);
  },
  postUpdate: function (user, updatedUser, callback) {

    User.findOneAndUpdate({_id: user._id}, {
      email: updatedUser.email || user.email,
      firstName: updatedUser.firstName || user.firstName,
      lastName: updatedUser.lastName || user.lastName,
      avatar: updatedUser.avatar || user.avatar,
      facebook: updatedUser.facebook || user.facebook,
      youtube: updatedUser.youtube || user.youtube
    }, {upsert: true}, function (err, newUser) {

      if (err) {
        throw err;
      }

      callback(err, newUser);
    });
  }
};