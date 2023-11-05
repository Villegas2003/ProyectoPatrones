function CityController() {

    this.ViewName = "Citie";
    this.ApiService = "CitieCRUD";

    this.InitView = function () {

        console.log("City view init");

        $("#btnCreateCity").click(function () {
            var vc = new CityController();
            vc.Create();
        })

        $("#btnUpdateCity").click(function () {
            var vc = new CityController();
            vc.Update();
        })

        $("#btnDeleteCity").click(function () {
            var vc = new CityController();
            vc.Delete();
        })

        //this.LoadTable();
    }
    this.Create = function () {

        /*
            EndPoint: https://localhost:7155/api/CitieCRUD/Create
            {
                 "id": 0,
                 "cityId": 0,
                  "name": "string",
                  "country": "string",
                  "latitude": 0,
                  "longitude": 0
            }
        */

        var city = {};
        city.name = $("#txtCity").val();
        city.country = $("#txtCountry").val();
        city.latitude = $("#numLatitude").val();
        city.logitude = $("#numLongitude").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, city, function () {
            console.log("City Created -->" + JSON.stringify(city));
        });

        console.log(JSON.stringify(city))
    }

    this.Update = function () {

        var city = {};
        city.id = $("#txtIdCity").val();
        city.name = $("#txtCity").val();
        city.country = $("#txtCountry").val();
        city.latitude = $("#numLatitude").val();
        city.longitude = $("#numLongitude").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, city, function () {

            console.log("City update --> " + JSON.stringify(city));
        });

        console.log(JSON.stringify(city))
    }

    this.Delete = function () {

        var city = {};
        city.id = $("#txtIdCity").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, city, function () {
            console.log("City delete -->" + JSON.stringify(city));

        });

        console.log(JSON.stringify(city))
    }

    this.LoadTable = function () {

        var ctrlActions = new ControlActions();

        var urlService = ctrlActions.GetUrlApiService(this.ApiService + "/RetrieveAll");

        /*
        
        
        
        
        
        */

        var columns = {};
        columns[0] = { 'data': 'id' };
        columns[1] = { 'data': 'nameCity' };
        columns[2] = { 'data': 'nameCountry' };
        columns[3] = { 'data': 'latitude' };
        columns[4] = { 'data': 'longitude' };


        $("#tblListCity").dataTable({
            "ajax": {
                "url": urlService,
                "dataSrc": ""
            },
            "columns": columns
        });

        $('#tblListCity tbody').on('click', 'tr', function () {

            var row = $(this).closet('tr');

            var cityData = $('#tblListCity').DataTable().row(row).data();
            $("#txtIdCity").value(cityData.id);
            $("#txtCity").value(cityData.city);
            $("#txtCountry").value(cityData.country);
            $("#numLatitude").value(cityData.latitude);
            $("#numLongitude").value(cityData.logitude);
        })
    }
}

$(document).ready(function () {
    var viewCont = new CityController();
    viewCont.InitView();
})