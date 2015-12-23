(function () {
  'use strict';

  function AddProjectController($location, identity, projects, licenses, notifier) {
    var vm = this;
    vm.identity = identity;

    licenses.getLicenses()
      .then(function (result) {
        vm.licenses = result;
      });

    vm.createProject = function (newProject) {
      projects.createProject(newProject)
        .then(function (createdProject) {
          notifier.success('Project created successfully!');
          $location.path('/projects/' + createdProject);
        });
    }
  }

  angular.module('myApp.controllers')
    .controller('AddProjectController', ['$location', 'identity', 'projects', 'licenses','notifier', AddProjectController]);

}());