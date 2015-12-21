(function () {
    'use strict';

    function CreateTripsController(cities, identity) {
        var vm = this;

        cities.getAllCities()
              .then(function (allCities) {
                  vm.cities = allCities;
              });

    }

    angular.module('myApp.controllers')
           .controller('CreateTripsController', ['cities', 'identity', CreateTripsController]);

}());