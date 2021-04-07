/// <reference path="../../../node_modules/angular-route/angular-route.js" />
/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pageCount = 0;
        $scope.getProductCategories = getProductCategories;

        function getProductCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize : 2
                }
            }
            apiService.get('/api/productcategory/getall', config, function (result) {
                // Ham success => tra ve du lieu resource
                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;

            }), function () {
                // Ham failed
                console.log('Load Producte Category Failed')
            }

        }

        $scope.getProductCategories();

    }

}
)(angular.module('shopaoquan.product_categories'));