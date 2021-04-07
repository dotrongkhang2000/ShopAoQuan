/// <reference path="../node_modules/angular/angular.js" />
/// <reference path="../node_modules/angular-route/angular-route.js" />

(function () {
    var app = angular.module('shopaoquan', ['shopaoquan.common', 'shopaoquan.products', 'shopaoquan.product_categories']);
    app.config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: "/app/components/home/homeView.html",
            controller: 'homeController'
        })
    })
})();

   