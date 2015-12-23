(function () {
  'use strict';

  function commits(data) {

    function getCommits() {
      return data.get('api/commits');
    }

    function getCommitsByProject(projectId) {
      return data.get('api/commits/byproject/' + projectId);
    }

    function getCommitsById(commitId) {
      return data.get('api/commits/' + commitId);
    }

    function createCommit(commit) {
      return data.post('api/commits', commit);
    }

    return {
      getCommits: getCommits,
      createCommit: createCommit,
      getCommitsByProject: getCommitsByProject,
      getCommitsById: getCommitsById
    }
  }

  angular.module('myApp.services')
    .factory('commits', ['data', commits]);

}());