superShoes.controller('rootCtrl',
    function ($scope, $rootScope, $location, superShoesApi) {
        
        $scope.isLoading = false;

        $scope.$on('requestStart', function (e) {
            $scope.isLoading = true;
        });

        $scope.$on('requestEnd', function (e) {
            $scope.isLoading = false;
        });
    }
);