(function () {
  'use strict';

  function ProjectInfoController($routeParams, identity, projects, commits, collaborators) {
    var vm = this;
    vm.id = $routeParams.id;
    vm.identity = identity;

    projects.getProjectById(vm.id)
      .then(function (project) {
        vm.project = project;
      });

    commits.getCommitsByProject(vm.id)
      .then(function (commits) {
        vm.projectCommits = commits;
      });

    collaborators.getCollaborators(vm.id)
      .then(function (collaborators) {
        vm.projectCollaborators = collaborators;
      });
  }

  angular.module('myApp.controllers')
    .controller('ProjectInfoController', ['$routeParams', 'identity', 'projects', 'commits', 'collaborators', ProjectInfoController]);

}());