(function () {
  'use strict';

  function projects(data) {

    function getPublicProjects() {
      return data.get('api/projects');
    }

    function getProjectById(id) {
      return data.get('api/projects/' + id);
    }

    function filterProjects(filters) {
      return data.get('api/projects/all', filters);
    }

    function createProject(project) {
      return data.post('api/projects', project);
    }

    return {
      getPublicProjects: getPublicProjects,
      filterProjects: filterProjects,
      createProject: createProject,
      getProjectById: getProjectById
    }
  }

  angular.module('myApp.services')
    .factory('projects', ['data', projects]);

}());