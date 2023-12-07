function UserController() {

    this.ViewName = "User";
    this.ApiService = "UserCRUD";

    this.InitView = function () {

        console.log("City view init");

        $("#btnCreateUser").click(function () {
            var vc = new UserController();
            vc.Create();
        })

        $("#btnUpdateUser").click(function () {
            var vc = new UserController();
            vc.Update();
        })

        $("#btnDeleteUser").click(function () {
            var vc = new UserController();
            vc.Delete();
        })

        //this.LoadTable();
    }
    this.Create = function () {

        /*
            EndPoint: https://localhost:7155/api/UserCRUD/Create
            {
                 "cedula": 1188653,
                 "name": "Malcom",
                 "email": "malcom@gmail.com",
                 "password": "Malcom1308!",
                 "id": 0
            }
        */

        var user = {};
        user.cedula = $("#txtId").val();
        user.name = $("#txtName").val();
        user.email = $("#txtEmail").val();
        user.password = $("#txtPass").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, user, function () {
            console.log("User Created -->" + JSON.stringify(user));
        });

        console.log(JSON.stringify(user))
    }

    this.Update = function () {

        var user = {};
        user.cedula = $("#txtId").val();
        user.name = $("#txtName").val();
        user.email = $("#txtEmail").val();
        user.password = $("#txtPass").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, user, function () {

            console.log("User update --> " + JSON.stringify(user));
        });

        console.log(JSON.stringify(user))
    }

    this.Delete = function () {

        var user = {};
        user.cedula = $("#txtId").val();
        user.name = $("#txtName").val();
        user.email = $("#txtEmail").val();
        user.password = $("#txtPass").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, user, function () {
            console.log("User delete -->" + JSON.stringify(user));

        });

        console.log(JSON.stringify(user))
    }

    //this.LoadTable = function () {

    //    var ctrlActions = new ControlActions();

    //    var urlService = ctrlActions.GetUrlApiService(this.ApiService + "/RetrieveAll");

    //    /*
        
        
        
        
        
    //    */

    //    var columns = {};
    //    columns[0] = { 'data': 'id' };
    //    columns[1] = { 'data': 'nameCity' };
    //    columns[2] = { 'data': 'nameCountry' };
    //    columns[3] = { 'data': 'latitude' };
    //    columns[4] = { 'data': 'longitude' };


    //    $("#tblListCity").dataTable({
    //        "ajax": {
    //            "url": urlService,
    //            "dataSrc": ""
    //        },
    //        "columns": columns
    //    });

    //    $('#tblListCity tbody').on('click', 'tr', function () {

    //        var row = $(this).closet('tr');

    //        var cityData = $('#tblListCity').DataTable().row(row).data();
    //        $("#txtIdCity").value(cityData.id);
    //        $("#txtCity").value(cityData.city);
    //        $("#txtCountry").value(cityData.country);
    //        $("#numLatitude").value(cityData.latitude);
    //        $("#numLongitude").value(cityData.logitude);
    //    })
    //}
}

$(document).ready(function () {
    var viewCont = new UserController();
    viewCont.InitView();
})