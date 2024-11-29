app.controller("RegisterController", function ($scope, RegisterService) {
    var userCredentials = [];
    $scope.cleanFunc = function () {
        $scope.firstName = null
        $scope.lastName = null
        $scope.address = null
        $scope.phoneNumber = null
    }

    $scope.submitFunc = function () {
        var userFind = userCredentials.find(UFind =>
            UFind.FirstName === $scope.firstName && UFind.LastName === $scope.lastName
        );

        if (userFind == undefined) {
            userCredentials.push({
                FirstName: $scope.firstName,
                LastName: $scope.lastName,
                UserAddress: $scope.address,
                UseNumber: $scope.phoneNumber,
                UserName: $scope.firstName + "." + $scope.lastName,
                UserPassword: $scope.lastName + $scope.phoneNumber
            });
            $scope.cleanFunc();
        }
        else {
            alert("Data is already existing");
        }
    }

    $scope.validateUser = function () {
        var validateData = RegisterService.validateUser($scope.firstName, $scope.lastName)
        validateData.then(function (returnedData) {
            var x = Number(returnedData.data)
            console.log(x)
        })
    }


    $scope.submitFunc2 = function () {
        var userInformation = {
            firstName: $scope.firstName,
            lastName: $scope.lastName,
            address: $scope.address, 
            phoneNumber: $scope.phoneNumber 
        }
        var postData = RegisterService.postUser(userInformation)
        postData.then(function (returnedData) {
            console.log(returnedData.data)
        })
    }

    $scope.login = function () {
        var username = $scope.loginUsername
        var password = $scope.loginPassword
        var userInformaiton = { username, password }
        var postData = RegisterService.loginUser(userInformaiton)
        postData.then((returnedData) => {
            console.log(returnedData.data)
        })

    }

    $scope.loadEmployee = function () {
        var getData = RegisterService.loadEmployee();
        getData.then(function (ReturnedData) {
            $scope.emptable = ReturnedData.data;
            $(document).ready(function () {
                $('#myTable').DataTable();
            });
        });
    }
});