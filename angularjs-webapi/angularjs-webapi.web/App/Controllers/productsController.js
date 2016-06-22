'use strict';

app.controller('productsController', [
    '$scope', 'productsService', function($scope, productsService) {
        $scope.message = "Product List";

        $scope.products = [];

        productsService.getProducts($scope);
    }
]);

app.controller('productController', [
    '$scope', '$routeParams', 'productsService', function($scope, $routeParams, productsService) {
        $scope.message = "Product";

        $scope.productId = $routeParams.Id;
        $scope.product = [];

        productsService.getProduct($scope);
    }
]);

app.service('productsService', ['$http', function ($http) {
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
        });
    };
    this.getProduct = function($scope) {
        return $http({
            method: "GET",
            url: "http://localhost:59113/api/Products/" + $scope.productId,
            headers: { 'Content-Type': 'application/json' }
        }).success(function (data) {
            $scope.product = data;
            console.log(data);
        }).error(function (data) {
            console.log(data);
        });
    }
}]);