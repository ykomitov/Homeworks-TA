(function () {
    'use strict';

    function cities($q, data) {

        function getAllCities() {
            return data.get('api/cities');
        }

        return {
            getAllCities: getAllCities
        }
    }

    angular.module('myApp.services')
           .factory('cities', ['$q', 'data', cities]);
}());