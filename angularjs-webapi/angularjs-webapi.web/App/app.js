"use strict";

var app = angular.module('myApp', ['ngRoute']);

app.config([
    '$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/', {
                controller: 'mainController',
                templateUrl: 'Views/Home.html'
            })
            .when('/home', {
                controller: 'mainController',
                templateUrl: 'Views/Home.html'
            })
            .when('/products', {
                //controller: 'productsController',
                templateUrl: 'Views/Products.html'
            })
            .when('/product/:Id', {
                //controller: 'productsController',
                templateUrl: 'Views/Product.html'
            })
            .otherwise({ redirectTo: '/' });
    }
]);