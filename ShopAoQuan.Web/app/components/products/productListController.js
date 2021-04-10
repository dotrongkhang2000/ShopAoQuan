/// <reference path="../../../node_modules/angular-route/angular-route.js" />
/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {
    app.controller('productListController', productListController);

    productListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox'];

    function productListController($scope, apiService, notificationService, $ngBootbox) {
        $scope.Product = [];
        $scope.page = 0;
        $scope.pageCount = 0;
        $scope.getProduct = getProduct;
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
                }
            };
            apiService.del('/api/productcategory/delete', config, function () {
                notificationService.displaySuccess('Xóa thành công');
                search();
            }, function () {
                notificationService.displayError('Xóa không thành công');
            })
        };



        function search() {
            getProduct();
        }
        function getProduct(page) {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize: 4,
                    keyword: $scope.keyword
                }
            }
            apiService.get('/api/product/getall', config, function (result) {
                //thong bao notificationService 
                if (result.data.TotalCount == 0) {
                    notificationService.displayWarning('Không có bản ghi nào !');
                }
                else {
                    notificationService.displaySuccess("Đã tìm thấy " + result.data.TotalCount + " bản ghi.");
                }
                // Ham success => tra ve du lieu resource
                $scope.Product = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;

            }), function () {
                // Ham failed
                console.log('Load Producte Failed')
            }

        }

        $scope.getProduct();

    }

}
)(angular.module('shopaoquan.products'));