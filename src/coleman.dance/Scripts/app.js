(function () {
    'use strict';

    config.$inject = ['$routeProvider', '$locationProvider'];

    angular.module('app', [
        'ngRoute', 'moviesServices', 'performancesServices',
    ]).config(config);

    //angular.module('performancesApp', [
    //    'ngRoute', 'performancesServices'
    //]).config(config);

    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/movies/add', {
                templateUrl: '/Views/add.html',
                controller: 'MoviesAddController'
            })
            .when('/movies/edit/:id', {
                templateUrl: '/Views/edit.html',
                controller: 'MoviesEditController'
            })
            .when('/movies/delete/:id', {
                templateUrl: '/Views/delete.html',
                controller: 'MoviesDeleteController'
            });

        $locationProvider.html5Mode(true);
    }

})();