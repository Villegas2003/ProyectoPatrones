function RouteController() {

    this.ViewName = "Route";
    this.ApiService = "RouteCRUD";

    this.InitView = function () {

        console.log("Route view init");

        $("#btnCreateRoute").click(function () {
            var hc = new RouteController();
            hc.Create();
        })
        $("#btnUpdateRoute").click(function () {
            var hc = new RouteController();
            hc.Update();
        })
        $("#btnDeleteRoute").click(function () {
            var hc = new RouteController();
            hc.Delete();
        })

        //this.LoadTable();
    }

    this.Create = function () {
        /*
            EndPoint: https://localhost:7155/api/RouteCRUD/Create
        {
            "idRoute": 0,
            "origin": "Paraiso",
            "destination": "San Pedro",
            "distance": "29",
            "transportUnit": "Hilux",
            "startpoint": "Centro de Paraiso",
            "finalpoint": "Ucenfotec",
            "id": 0
        }
        */

        var route = {};
        route.origin = $("#txtOrigen").val();
        route.destination = $("#txtDestination").val();
        route.distance = $("#txtDistance").val();
        route.transportUnit = $("#txtTransport").val();
        route.startpoint = $("#txtStarPoint").val();
        route.finalpoint = $("#txtFinalPoint").val();


        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, route, function () {
            console.log("Route created -->" + JSON.stringify(route));
        });
        console.log(JSON.stringify(route))
    }

    this.Update = function () {

        var route = {};
        route.idRoute = $("#txtId").val();
        route.origin = $("#txtOrigen").val();
        route.destination = $("#txtDestination").val();
        route.distance = $("#txtDistance").val();
        route.transportUnit = $("#txtTransport").val();
        route.startpoint = $("#txtStarPoint").val();
        route.finalpoint = $("#txtFinalPoint").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, route, function () {
            console.log("Route Update -->" + JSON.stringify(route));
        });
        console.log(JSON.stringify(route))
    }

    this.Delete = function () {

        var route = {};
        route.idRoute = $("#txtId").val();
        route.origin = $("#txtOrigen").val();
        route.destination = $("#txtDestination").val();
        route.distance = $("#txtDistance").val();
        route.transportUnit = $("#txtTransport").val();
        route.startpoint = $("#txtStarPoint").val();
        route.finalpoint = $("#txtFinalPoint").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, route, function () {
            console.log("Route delete -->" + JSON.stringify(route));
        });
        console.log(JSON.stringify(route))
    }

    //this.LoadTable = function () {
    //    var ctrlActions = new ControlAction();
    //    var urlService = ctrlActions.GetUrlApiService(this.ApiService + "/RetrieveAll");

    //    /*
        
        
        
        
        
    //    */

    //    var columns = {};
    //    columns[0] = { 'data': 'id' };
    //    columns[1] = { 'data': 'date' };
    //    columns[2] = { 'data': 'maxTemperature' };
    //    columns[3] = { 'data': 'minTemperature' };
    //    columns[4] = { 'data': 'condition' };

    //    $("#tblListHistory").dataTable({
    //        "ajax": {
    //            "url": urlService,
    //            "dataSrc": ""
    //        },
    //        "columns": columns
    //    });

    //    $('#tblListHistory tbody').on('click', 'tr', function () {

    //        var row = $(this).closet('tr');

    //        var historyData = $('#tblListHistory').DataTable().row(row).data();
    //        $("#txtIdHis").value(historyData.id);
    //        $("#txtDateHis").value(historyData.date);
    //        $("#numMaxTemperatureHis").value(historyData.maxTemperature);
    //        $("#numMinTemperatureHis").value(historyData.minTemperature);
    //        $("#txtConditionHis").value(historyData.condition);
    //    })
    //}
}

$(document).ready(function () {
    var viewCont = new RouteController();
    viewCont.InitView();
})
