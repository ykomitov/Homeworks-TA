(function () {
    'use strict';

    function trips(data) {

        function getPublicTrips() {
            return data.get('api/trips');
        }

        return {
            getPublicTrips: getPublicTrips
        }
    }

    angular.module('myApp.services')
           .factory('trips', ['data', trips]);

}());