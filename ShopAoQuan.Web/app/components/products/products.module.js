/// <reference path="../../../node_modules/angular-route/angular-route.js" />

(function () {
    var app = angular.module('shopaoquan.products', ['shopaoquan.common']);


    app.config(function ($routeProvider) {
        $routeProvider.when("/products", {
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).when("/product_add", {
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        });
    });


})();