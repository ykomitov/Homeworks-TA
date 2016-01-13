'use strict';

let db = require('./mongoose-settings')();
let User = require('mongoose').model('User');
let Message = require('mongoose').model('Message');

module.exports = {
  registerUser: function (user) {

    if (!user.user || !user.pass) {
      console.log('The user must have both username and password!');
      return;
    }

    let newUser = new User(user);

    newUser.save(function (err) {
      if (err) {
        console.log(err);
      }
    });
  },
  sendMessage: function (message) {
    let newMessage = new Message(message);

    newMessage.save(function (err) {
      if (err) {
        console.log(err);
      }
    })
  },
  getMessages: function (users) {
    let messages = Message.find()
      .where('from')
      .equals(users.with)
      .where('to')
      .equals(users.and)
      .exec(function (err, receivedMessages) {
        if (err) {
          console.log(err);
        }
        console.log(receivedMessages);
      });
  }
};