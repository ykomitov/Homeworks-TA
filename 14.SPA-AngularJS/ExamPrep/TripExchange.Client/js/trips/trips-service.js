(function () {
    'use strict';

    function trips(data) {

        function getPublicTrips() {
            return data.get('api/trips');
        }

        function createTrip(trip) {
            return data.post('api/trips', trip);
        }

        return {
            getPublicTrips: getPublicTrips,
            createTrip: createTrip
        }
    }

    angular.module('myApp.services')
           .factory('trips', ['data', trips]);

}());