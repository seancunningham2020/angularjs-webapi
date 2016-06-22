'use strict';

var app = angular.module('myApp', []);

app.controller('homeController', ['$scope', 'productService', function ($scope, productService) {
    $scope.message = "Product List";

    $scope.products = [];

    productService.getProducts($scope);
}])

app.service('productService', ['$http', function ($http) {
    this.getProducts = function ($scope) {
        return $http({
            method: "GET",
            url: "http://localhost:59113/api/Products/",
            headers: { 'Content-Type': 'application/json' }
        }).success(function (data) {
            $scope.products = data;
            console.log(data);
        }).error(function (data) {
            console.log(data);
        });;
    };
}]);