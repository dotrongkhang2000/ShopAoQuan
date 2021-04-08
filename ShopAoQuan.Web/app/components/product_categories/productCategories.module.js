/// <reference path="../../../node_modules/angular-route/angular-route.js" />

(function () {
    var app = angular.module('shopaoquan.product_categories', ['shopaoquan.common']);

    app.config(function ($routeProvider, $stateProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "productCategoryListController"
        }).state('product_categories_edit', {
            url: "/product_categories_edit/:id",
            templateUrl: "/app/components/product_categories/productCategoryEditView.html",
            controller: "productCategoryEditController"
        }).state('product_categories_add', {
            url: "/product_categories_add",
            templateUrl: "/app/components/product_categories/productCategoryAddView.html",
            controller: "productCategoryAddController"
        })
        //$routeProvider
            //.when('/product_categories', {
            //templateUrl: "/app/components/product_categories/productCategoryListView.html",
            //controller: "productCategoryListController"
            //})
        //    .when("/product_categories_add", {
        //    templateUrl: "/app/components/product_categories/productCategoryAddView.html",
        //    controller: "productCategoryAddController"
        //})
        //}).when("/product_categories_edit/:id", {
        //    templateUrl: "/app/components/product_categories/productCategoryEditView.html",
        //    controller: "productCategoryEditController"
        //})
    });
})();

