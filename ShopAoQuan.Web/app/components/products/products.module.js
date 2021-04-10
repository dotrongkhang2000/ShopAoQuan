/// <reference path="../../../node_modules/angular-route/angular-route.js" />

(function () {
    var app = angular.module('shopaoquan.products', ['shopaoquan.common']);


    app.config(function ($routeProvider, $stateProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('products_add', {
            url: "/products_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        }).state('products_edit', {
            url: "/products_edit/:id",
            templateUrl: "/app/components/products/productEditView.html",
            controller: "productEditController"
        });
    });


})();