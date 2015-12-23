(function () {
  'use strict';

  function CommitsController(identity, commits) {
    var vm = this;
    vm.identity = identity;

    commits.getCommits()
      .then(function (commits) {
        vm.commits = commits;
      });

  }

  angular.module('myApp.controllers')
    .controller('CommitsController', ['identity', 'commits', CommitsController]);

}());