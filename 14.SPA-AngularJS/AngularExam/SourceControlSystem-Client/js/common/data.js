(function () {
    'use strict';

    function data($http, $q, notifier, baseServiceUrl, authorization) {

        function get(url, queryParams) {
            var deferred = $q.defer();
            var authHeader = authorization.getAuthorizationHeader();

            $http.get(baseServiceUrl + '/' + url, { params: queryParams, headers: authHeader })
                 .then(function (response) {
                     deferred.resolve(response.data);
                 }, function (err) {
                     err = getErrorMessage(err);
                     notifier.error(err);
                     deferred.reject(err);
                 });

            return deferred.promise;
        }

        function post(url, postData) {
            var deferred = $q.defer();
            var authHeader = authorization.getAuthorizationHeader();

            $http.post(baseServiceUrl + '/' + url, postData, { headers: authHeader })
                 .then(function (response) {
                     deferred.resolve(response.data);
                 }, function (err) {
                     err = getErrorMessage(err);
                     notifier.error(err);
                     deferred.reject(err);
                 });

            return deferred.promise;
        }

        function put() {
            throw new Error('Not implemented!');
        }

        function getErrorMessage(response) {

            var error = response.data.modelState;

            if (error && error[Object.keys(error)[0]][0]) {
                error = error[Object.keys(error)[0]][0];
            }
            else {
                error = response.data.message;
            }

            return error;
        }

        return {
            get: get,
            post: post,
            put: put
        }
    }

    angular.module('myApp.services')
           .factory('data', ['$http', '$q', 'notifier', 'baseServiceUrl', 'authorization', data]);

}());