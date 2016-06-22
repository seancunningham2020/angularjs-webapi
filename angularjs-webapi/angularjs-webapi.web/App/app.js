"use strict";

var app = angular.module('myApp', ['ngRoute']);

app.config([
    '$routeProvider', '$locationProvider', function($routeProvider) {
        $routeProvider
            .when('/', {
                //controller: 'mainController',
                templateUrl: 'Views/Home.html'
            })
            .when('/home', {
                templateUrl: 'Views/Home.html'
            })
            .when('/products', {
                templateUrl: 'Views/Products.html'
            })
            .when('/product/:Id', {
                templateUrl: 'Views/Product.html'
            })
            .otherwise({ redirectTo: '/' });
    }
]);