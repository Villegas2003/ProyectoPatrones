function CarriersController() {

    this.ViewName = "Carriers";
    this.ApiService = "CarriersCrud";

    this.InitView = function () {

        console.log("Carriers view init");

        $("#btnCreateCarrier").click(function () {
            var dt = new CarriersController();
            dt.Create();
        })

        $("#btnUpdateCarrier").click(function () {
            var dt = new CarriersController();
            dt.Update();
        })

        $("#btnDeleteCarrier").click(function () {
            var dt = new CarriersController();
            dt.Delete();
        })

        //this.LoadTable();
    }

    this.Create = function () {

        /*
            EndPoint: https://localhost:7155/api/CarriersCrud/Create
            {
                "idCarriers": 0,
                "name": "Malcom",
                "carRegistration": "349058",
                "vehicleType": "Hino",
                "ability": 10,
                "id": 0
            }       
        */

        var carrier = {};
        carrier.name = $("#txtName").val();
        carrier.carRegistration = $("#numVehicle").val();
        carrier.vehicleType = $("#txtType").val();
        carrier.ability = $("#numAbility").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, carrier, function () {
            console.log("Carriers created -->" + JSON.stringify(carrier));
        });

        console.log(JSON.stringify(carrier))
    }

    this.Update = function () {

        var carrier = {};
        carrier.idCarriers = $("#numid").val();
        carrier.name = $("#txtName").val();
        carrier.carRegistration = $("#numVehicle").val();
        carrier.vehicleType = $("#txtType").val();
        carrier.ability = $("#numAbility").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, carrier, function () {
            console.log("Carriers update -->" + JSON.stringify(carrier));
        });

        console.log(JSON.stringify(carrier))
    } 

    this.Delete = function () {

        var carrier = {};
        carrier.idCarriers = $("#numid").val();
        carrier.name = $("#txtName").val();
        carrier.carRegistration = $("#numVehicle").val();
        carrier.vehicleType = $("#txtType").val();
        carrier.ability = $("#numAbility").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, carrier, function () {
            console.log("Carriers delete -->" + JSON.stringify(carrier));
        });

        console.log(JSON.stringify(carrier))
    }

    //this.LoadTable = function () {

    //    var ctrlActions = new CurrentDataController();
    //    var urlService = ctrlActions.GetUrlApiService(this.ApiService + "/RetrieveAll");

    //    /*
        
        
        
    //    */

    //    var columns = {};
    //    columns[0] = { 'data': 'id' };
    //    columns[1] = { 'data': 'timeStamp' };
    //    columns[2] = { 'data': 'temperature' };
    //    columns[3] = { 'data': 'humidity' };
    //    columns[4] = { 'data': 'condition' };
    //    columns[5] = { 'data': 'windSpeed' };

    //    $("#tblListCurrentData").dataTable({
    //        "ajax": {
    //            "url": urlService,
    //            "dataSrc": ""
    //        },
    //        "columns": columns
    //    });

    //    $('#tblListCurrentData tbody').on('click', 'tr', function () {
    //        var row = $(this).closet('tr');

    //        var currentData = $('#tblListCurrentData').DataTable().row(row).data();
    //        $("#txtIdCurrent").value(currentData.id);
    //        $("#dtTimeStampCurrent").value(currentData.timestamp);
    //        $("#numTemperatureCurrent").value(currentData.temperature);
    //        $("#numHumidityCurrent").value(currentData.humidity);
    //        $("#txtConditionCurrent").value(currentData.condition);
    //        $("#numWindSpeedCurrent").value(currentData.windseepd);
    //    })
    //}
}

$(document).ready(function () {
    var viewCont = new CarriersController();
    viewCont.InitView();
})
