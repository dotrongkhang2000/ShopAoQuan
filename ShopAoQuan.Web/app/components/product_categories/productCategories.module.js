/// <reference path="../../../node_modules/angular-route/angular-route.js" />

(function () {
    var app = angular.module('shopaoquan.product_categories', ['shopaoquan.common']);

    app.config(function ( $stateProvider) {
        $stateProvider
            .state('product_categories', {
                url: "/product_categories",
                //parent: 'base',
                templateUrl: "/app/components/product_categories/productCategoryListView.html",
                controller: "productCategoryListController"
            }).state('product_categories_edit', {
                url: "/product_categories_edit/:id",
                //parent: 'base',
                templateUrl: "/app/components/product_categories/productCategoryEditView.html",
                controller: "productCategoryEditController"
            }).state('product_categories_add', {
                url: "/product_categories_add",
                //parent: 'base',
                templateUrl: "/app/components/product_categories/productCategoryAddView.html",
                controller: "productCategoryAddController"
            })
    });
})();

