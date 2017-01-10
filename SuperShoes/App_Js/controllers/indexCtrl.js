superShoes.controller('indexCtrl', 
    function ($scope, $rootScope, $location, superShoesApi) {
        
        $scope.stores = [];

        function init() {
            superShoesApi.getStores(onGetStoresSuccess);
        }

        function onGetStoresSuccess(response) {
            $scope.stores = response.data.Stores;
        }

        init();
    }
);