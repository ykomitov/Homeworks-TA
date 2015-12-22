(function () {
    'use strict';

    function trips(data) {

        function getPublicTrips() {
            return data.get('api/trips');
        }

        function createTrip(trip) {
            return data.post('api/trips', trip);
        }

        function filterTrips(filters) {
            return data.get('api/trips', filters);
        }

        return {
            getPublicTrips: getPublicTrips,
            createTrip: createTrip,
            filterTrips: filterTrips
        }
    }

    angular.module('myApp.services')
           .factory('trips', ['data', trips]);

}());