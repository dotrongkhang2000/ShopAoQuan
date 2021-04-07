/// <reference path="../../../node_modules/angular-route/angular-route.js" />
/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];

            $scope.getProductCategories = getProductCategories;

        function getProductCategories(){
            apiService.get('/api/productcategory/getall', null, function (result) {
                // Ham success => tra ve du lieu resource
                $scope.productCategories = result.data;
            }), function () {
                // Ham failed
                console.log('Load Producte Category Failed')
            }

        }

        $scope.getProductCategories();

    }

}
) (angular.module('shopaoquan.product_categories'));