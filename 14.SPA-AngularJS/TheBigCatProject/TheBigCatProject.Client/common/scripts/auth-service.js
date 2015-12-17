(function () {
    'use strict';

    var authService = function authService($http, $q, $cookies, identity, baseUrl, toaster) {
        var TOKEN_KEY = 'authentication';

        var register = function register(user) {
            var defered = $q.defer();

            $http.post(baseUrl + '/api/account/register', user)
                .then(function () {
                    defered.resolve(true);
                }, function (err) {
                    toaster.error(err.data.ModelState[Object.keys(err.data.ModelState)[0]][0]);
                    console.log(err.data.ModelState[Object.keys(err.data.ModelState)[0]][0]);
                    defered.reject(err);
                });

            return defered.promise;
        };

        var login = function login(user) {
            var deferred = $q.defer();

            // process data with url-encoded format because Web Api expects it that way
            var data = "grant_type=password&username=" + (user.email || '') + '&password=' + (user.password || '');

            // set header in order to prevent Angular automatically serializing data to JSON
            $http.post(baseUrl + '/Token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                .success(function (response) {

                    // token for authorized access
                    var tokenValue = response.access_token;

                    // cookie expiration date
                    var theBigDay = new Date();
                    theBigDay.setHours(theBigDay.getHours() + 72);

                    // save cookie for refresh scenarios
                    $cookies.put(TOKEN_KEY, tokenValue, { expires: theBigDay });

                    // set default authorization header, so that we don't need to provide the header with every request
                    $http.defaults.headers.common.Authorization = 'Bearer ' + tokenValue;

                    // login user after receiving access token
                    getIdentity().then(function () {
                        deferred.resolve(response);
                    });
                })
                .error(function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        };

        var getIdentity = function () {
            var deferred = $q.defer();

            $http.get(baseUrl + '/api/account/identity')
                .success(function (identityResponse) {
                    identity.setUser(identityResponse);
                    deferred.resolve(identityResponse);
                });

            return deferred.promise;
        };

        return {
            register: register,
            login: login,
            getIdentity: getIdentity,
            isAuthenticated: function () {
                return !!$cookies.get(TOKEN_KEY);
            },
            logout: function () {
                $cookies.remove(TOKEN_KEY);
                $http.defaults.headers.common.Authorization = null;
                identity.removeUser();
            },
        };
    };

    angular
        .module('catApp.services')
        .factory('auth', ['$http', '$q', '$cookies', 'identity', 'baseUrl','toaster', authService]);
}());