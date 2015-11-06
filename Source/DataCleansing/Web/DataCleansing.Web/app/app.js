'use strict';

var dataApp = angular
    .module('dataApp', ['ngResource', 'ngRoute', 'ngFileUpload', 'ngStorage', 'checklist-model', 'ui.bootstrap'])
    .config(function ($routProvider) {
        $routProvider
            .when('/', {
                templateUrl: '/app/templates/profile.httm'
            })
            .when('/editUser', {
                templateUrl: '/app/templates/editUser.html'
            })
            .when('/editBilling', {
                templateUrl: '/app/terplates/editBilling.html'
            })
            .when('/invoice', {
                templateUrl: '/app/templates/invoice.html'
            })
            .when('/topUp', {
                templateUrl: '/app/templates/topUp.html'
            })
            .when('/buy/:id', {
                templateUrl: '/app/templates/buy.html'
            })
            .when('/success', {
                templateUrl: '/app/templates/success.html'
            })
            .when('/services', {
                templateUrl: '/app/templates/services.html'
            })
            .when('/address', {
                templateUrl: '/app/templates/single/address.html'
            })
            .when('/iban', {
                templateUrl: '/app/templates/single/iban.html'
            })
            .when('/telephone', {
                templateUrl: '/app/templates/single/telephone.html'
            })
            .when('/email', {
                templateUrl: '/app/templates/single/email.html'
            })
            .when('/bic', {
                templateUrl: '/app/templates/single/bic.html'
            })
            .when('/card', {
                templateUrl: '/app/templates/single/card.html'
            })
            .when('/bulkAddress', {
                templateUrl: '/app/templates/bulk/bulkAddress.html'
            })
            .when('/bulkEmail', {
                templateUrl: '/app/templates/bulk/bulkEmail.html'
            })
            .when('/bulkTelaphone', {
                templateUrl: '/app/templates/bulk/bulkTelephone.html'
            })
            .when('/buklkIban', {
                templateUrl: '/app/templates/bulk/bulkIban.html'
            })
            .when('/bulkBic', {
                templateUrl: '/app/templates/bulk/bulkIban.html'
            })
            .when('bulkCard', {
                templateUrl: '/app/templates/bulk/bulkCard.html'
            })
            .when('/deduplicate', {
                templateUrl: '/app/templates/deduplicate.html'
            })
    });