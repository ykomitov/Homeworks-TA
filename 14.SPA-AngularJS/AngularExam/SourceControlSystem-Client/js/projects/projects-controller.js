(function () {
  'use strict';

  function ProjectsController(identity, projects) {
    var vm = this;
    vm.identity = identity;
    vm.request = {
      page: 1
    };

    vm.filterProjects = function () {
      projects.filterProjects(vm.request)
        .then(function (filteredProjects) {
          vm.projects = filteredProjects;
        });
    };

    vm.prevPage = function () {
      if (vm.request.page == 1) {
        return;
      }
      vm.request.page--;
      vm.filterProjects();
    };

    vm.nextPage = function () {
      vm.request.page++;
      vm.filterProjects();
    };

    projects.getPublicProjects()
      .then(function (projects) {
        vm.projects = projects;
      });
  }

  angular.module('myApp.controllers')
    .controller('ProjectsController', ['identity', 'projects', ProjectsController]);

}());