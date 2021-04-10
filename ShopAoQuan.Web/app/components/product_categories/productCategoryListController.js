/// <reference path="../../../node_modules/angular-route/angular-route.js" />
/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function productCategoryListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pageCount = 0;
        $scope.getProductCategories = getProductCategories;
        $scope.keyword = '';

        $scope.search = search;
        

        $scope.deleteProductCategory = deleteProductCategory;

        function deleteProductCategory(id) {
            //$ngBootbox.confirm('Bạn có chắc muốn xóa?').then(function () {
            //    var config = {
            //        params: {
            //            id: id
            //        }
            //    }

                var config = {
                    params: {
                        id: id
                    }};
                apiService.del('/api/productcategory/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công');
                    search();
                }, function () {
                    notificationService.displayError('Xóa không thành công');
                })
            };
        


        function search() {
            getProductCategories();
        }
        function getProductCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize: 4,
                    keyword: $scope.keyword
                }
            }
            apiService.get('/api/productcategory/getall', config, function (result) {
                //thong bao notificationService 
                if (result.data.TotalCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào thõa mãn điều kiện!');
                }
                else {
                    notificationService.displaySuccess("Đã tìm thấy " + result.data.TotalCount + " bản ghi.");
                }
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