app.service("RegisterService", function ($http) {
    this.validateUser = function (FName, LName) {
        var response = $http({
            method: "post",
            url: "/Home/validateUserFunc",
            params: {
                firstName: FName,
                lastName: LName
            }
        })
        return response
    }

    this.postUser = function (userInformation) {
        var response = $http({
            method: "post",
            url:"/Home/UpdateEmployee",
            data: userInformation 
        })
        return response
    }

    this.loginUser = function (userInformation) {
        var response = $http({
            method: "post",
            url: "/Home/loginUser",
            data: userInformation
        })
        return response
    }

    this.loadEmployee = function () {
        return $http.get("/Home/LoadEmployees");
    }
});