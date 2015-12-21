(function () {
    'use strict';

    function CreateTripsController($location, cities, trips) {
        var vm = this;

        cities.getAllCities()
              .then(function (allCities) {
                  vm.cities = allCities;
              });

        vm.createTrip = function (newTrip) {
            trips.createTrip(newTrip)
                 .then(function (createdTrip) {
                     $location.path('/trips/details/' + createdTrip.id);
                 }, function () {

                 });
        }

    }

    angular.module('myApp.controllers')
           .controller('CreateTripsController', ['$location', 'cities', 'trips', CreateTripsController]);

}());