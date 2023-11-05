function ForeCastController() {
    this.ViewName = "ForeCast";
    this.ApiService = "ForeCastCRUD";

    this.InitView = function () { 

        console.log("ForeCast view init");

        $("#btnCreateForeCast").click(function () {
            var fc = new ForeCastController();
            fc.Create();
        })
        $("#btnUpdateForeCast").click(function () {
            var fc = new ForeCastController();
            fc.Update();
        })
        $("#btnDeleteForeCast").click(function () {
            var fc = new ForeCastController();
            fc.Delete();
        })

        //This.LoadTable();
    }

    this.Create = function (){

        /*
            EndPoint: https://localhost:7155/api/ForeCastCRUD/Create 
        {
          "foreCastId": 0,
          "date": "2023-11-03T15:00:53.999Z",
          "maxTemperature": 21,
          "minTemperature": 1,
          "condition": "Nublado",
          "cityId": 0,
          "id": 0
        }
        */

        var fore = {};
        fore.date = $("#txtDateFore").val();
        fore.maxTemperature = $("#numMaxTemperatureFore").val();
        fore.minTemperature = $("#numMinTemperatureFore").val();
        fore.condition = $("#txtConditionFore").val(); 

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, fore, function () {
            console.log("ForeCast Create -->" + JSON.stringify(fore));
        });
        console.log(JSON.stringify(fore))
    }

    this.Update = function () {
        var fore = {};
        fore.id = $("#txtIdFore").val();
        fore.date = $("#txtDateFore").val();
        fore.maxTemperature = $("#numMaxTemperatureFore").val();
        fore.minTemperature = $("#numMinTemperatureFore").val();
        fore.condition = $("#txtConditionFore").val(); 

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, fore, function () {
            console.log("ForeCast Update -->" + JSON.stringify(fore));
        });
        console.log(JSON.stringify(fore))
    }

    this.Delete = function () {

        var fore = {};
        fore.id = $("#txtIdFore").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, fore, function () {
            console.log("ForeCast Delete -->" + JSON.stringify(fore));
        });
        console.log(JSON.stringify(fore))
    }

    this.LoadTable = function () {

        var ctrlActions = new ControlAction();
        var urlService = ctrlActions.GetUrlApiService(this.ApiService + "/RetrieveAll");

        /*
        
        
        
        */

        var columns = {};
        columns[0] = { 'data': 'id' };
        columns[1] = { 'data': 'date' };
        columns[2] = { 'data': 'maxTemperature' };
        columns[3] = { 'data': 'minTemperature' };
        columns[4] = { 'data': 'condition' };

        $("#tblListForeCast").dataTable({
            "ajax": {
                "url": urlService,
                "dataSrc": ""
            },
            "columns": columns
        });

        $('#tblListForeCast tbody').on('click', 'tr', function () {
            var row = $(this).closet('tr');

            var foreData = $('#tblListForeCast').DataTable().row(row).data();
            $("#txtIdFore").value(foreData.id);
            $("#txtDateFore").value(foreData.date);
            $("#numMaxTemperatureFore").value(foreData.maxTemperature);
            $("#numMinTemperatureFore").value(foreData.minTemperature);
            $("#txtConditionFore").value(foreData.condition);


        })
    }
}

$(document).ready(function () {
    var viewCont = new ForeCastController();
    viewCont.InitView();
})
