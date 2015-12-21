(function () {
    'use strict';

    function data($http, $q, notifier, baseServiceUrl) {

        function get(url, queryParams) {
            var deferred = $q.defer();

            $http.get(baseServiceUrl + '/' + url, { params: queryParams })
                 .then(function (response) {
                     deferred.resolve(response.data);
                 }, function (err) {
                     notifier.error(err);
                     deferred.reject(err);
                 });

            return deferred.promise;
        }

        function post(url, postData) {
            var deferred = $q.defer();

            $http.post(baseServiceUrl + '/' + url, postData)
                 .then(function (response) {
                     deferred.resolve(response.data);
                 }, function (err) {
                     notifier.error(err);
                     deferred.reject(err);
                 });

            return deferred.promise;
        }

        function put() {
            throw new Error('Not implemented!');
        }

        return {
            get: get,
            post: post,
            put: put
        }
    }

    angular.module('myApp.services')
           .factory('data', ['$http', '$q', 'notifier', 'baseServiceUrl', data]);

}());