/// <reference path="../node_modules/angular/angular.js" />
/// <reference path="../node_modules/angular-route/angular-route.js" />

(function () {
    var app = angular.module('shopaoquan', ['shopaoquan.common', 'shopaoquan.products', 'shopaoquan.product_categories']);
    app.config(function ($routeProvider, $stateProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: 'homeController'
        })
        //$stateProvider.state('base', {
        //    url: '',
        //    templateUrl: '/app/shared/views/baseView.html',
        //    //tạo lớp để các lớp con khác kế thừa
        //    abstract: true
        //})
        //    .state('login', {
        //    url: "/login",
        //    templateUrl: "/app/components/login/loginView.html",
        //    controller: "loginController"
        //})
        //    .state('home', {
        //    url: "/admin",
        //    parent: 'base',
        //    templateUrl: "/app/components/home/homeView.html",
        //    controller: "homeController"
        //});
        //$urlRouterProvider.otherwise('/login');
    })
})();

