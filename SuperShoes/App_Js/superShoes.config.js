superShoes.config([
    '$locationProvider', '$routeProvider','$httpProvider', '$base64',
    function config($locationProvider, $routeProvider, $httpProvider, $base64) {
        $routeProvider
        .when('/', {
            controller: 'indexCtrl',
            templateUrl: '/App_Js/templates/stores.html'
        })
        .when('/store/:id', {
            controller: 'storeCtrl',
            templateUrl: '/App_Js/templates/store.html'
        })
        .when('/articles', {
            controller: 'articlesCtrl',
            templateUrl: '/App_Js/templates/articles.html'
        })
        .otherwise('/');

        var auth = $base64.encode("my_user:my_password");
        $httpProvider.defaults.headers.common['Authorization'] = 'Basic ' + auth;
    }
]).run(function ($rootScope, $location) {
    //
});