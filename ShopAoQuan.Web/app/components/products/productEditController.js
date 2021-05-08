/// <reference path="../../../node_modules/angular/angular.js" />

(function (app) {

    app.controller('productEditController', productEditController);

    productEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', "$stateParams", 'commonService'];

    function productEditController(apiService, $scope, notificationService, $state, $stateParams, commonService) {

        $scope.product = {
            CreateDate: new Date(),
            Status: true,
        }



        //Setup config default cho CK Edittor
        $scope.ckeditorOptions = {
            laguage: 'vi',
            height : '200px'
        }

        $scope.EditProduct = EditProduct;
        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.product.Name);
        }

        //stateParams là nơi lưu các tham số của state này 
        function loadProductById() {
            apiService.get("/api/product/getbyid/" + $stateParams.id, null, function (result) {
                $scope.product = result.data;
            }, function (error) {
                console.log("Lấy dữ liệu thất bại !");
            });
        }

        function loadProductCategories() {
            apiService.get("/api/productcategory/getallparent", null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log("Lấy dữ liệu thất bại!");
            });
        }

        function EditProduct() {
            apiService.put("/api/product/update", $scope.product, function (result) {
                notificationService.displaySuccess(result.data.Name + "đã được cập nhật thành công !");
                $state.go('products');
            }, function (error) {
                notificationService.displayError("Cập nhật thất bại !");
            });
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }

        loadProductCategories();
        loadProductById();
    };


})(angular.module('shopaoquan.products'));