﻿/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {

    app.controller('productAddController', productAddController);

    //Gọi Service để lấy dữ liệu
    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function productAddController(apiService, $scope, notificationService, $state) {

        $scope.product = {
            CreatedDate: new Date(),
            Status: true
        }
        $scope.ckeditorOptions = {
            language : 'vi',
            height: '200px'     
        }
        $scope.AddProduct = AddProduct;
        //binding dữ liệu parentCategory

        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }

        function AddProduct() {
            apiService.post('/api/productcategory/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        function loadProductCategory() {
            //Tạo API
            apiService.get("/api/productcategory/getallparent", null, function (result) {
                $scope.productCategories  = result.data;
            }, function () {
                console.log("Lấy dữ liêu parent thất bại!");
            });
        }
        
        loadProductCategory();
    };


})(angular.module('shopaoquan.product_categories'));