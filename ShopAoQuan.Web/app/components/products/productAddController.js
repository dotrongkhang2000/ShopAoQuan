/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {

    app.controller('productAddController', productAddController);

    //Gọi Service để lấy dữ liệu
    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService' ];

    function productAddController(apiService, $scope, notificationService, $state, commonService) {

        $scope.product = {
            CreatedDate: new Date(),
            Status: true,
        }

        $scope.ckeditorOptions = {
            language : 'vi',
            height: '200px'     
        }
        $scope.GetSeoTitle = GetSeoTitle;

        $scope.AddProduct = AddProduct;
        //binding dữ liệu parentCategory


        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }

        function AddProduct() {
            apiService.post('/api/product/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        function loadProduct() {
            //Tạo API
            apiService.get("/api/productcategory/getallparent", null, function (result) {
                $scope.productCategories  = result.data;
            }, function () {
                console.log("Lấy dữ liêu parent thất bại!");
            });
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }

        loadProduct();
    };


})(angular.module('shopaoquan.products'));