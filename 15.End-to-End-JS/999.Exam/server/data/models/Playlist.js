var mongoose = require('mongoose');

var requiredMessage = '{PATH} is required';

module.exports.init = function () {
  var playlistSchema = mongoose.Schema({
    title: {type: String, required: requiredMessage},
    description: {type: String, required: requiredMessage},
    videoUrls: [{type: String, required: requiredMessage}],
    category: {type: String, required: requiredMessage},
    creator: {type: String, required: requiredMessage},
    creationDate: {type: Date, required: requiredMessage},
    isPrivate: {type: Boolean, required: requiredMessage},
    ratings: [{type: Number, min: 1, max: 5}],
    rating: Number
  });

  var Playlist = mongoose.model('Playlist', playlistSchema);
};


