superShoes.controller('articlesCtrl',
    function ($scope, $rootScope, $routeParams, $location, superShoesApi) {

        $scope.stores = [];

        function init() {
            superShoesApi.getArticles(onGetArticlesSuccess);
        }

        function onGetArticlesSuccess(response) {
            $scope.articles = response.data.Articles;
        }

        init();
    }
);