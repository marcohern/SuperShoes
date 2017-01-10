superShoes.controller('storeCtrl',
    function ($scope, $rootScope, $routeParams, $location, superShoesApi) {

        $scope.stores = [];

        function init() {
            superShoesApi.getStore($routeParams.id, onGetStoreSuccess);
        }

        function onGetStoreSuccess(response) {
            $scope.store = response.data.Store;
        }

        init();
    }
);