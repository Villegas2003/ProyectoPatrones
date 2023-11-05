function CurrentDataController() {

    this.ViewName = "CurrentData";
    this.ApiService = "CurrentDataCrud";

    this.InitView = function () {

        console.log("CurrentData view init");

        $("#btnCreateCurrent").click(function () {
            var dt = new CurrentDataController();
            dt.Create();
        })

        $("#btnUpdateCurrent").click(function () {
            var dt = new CurrentDataController();
            dt.Update();
        })

        $("#btnDeleteCurrent").click(function () {
            var dt = new CurrentDataController();
            dt.Delete();
        })

        //this.LoadTable();
    }

    this.Create = function () {

        /*
            EndPoint: https://localhost:7155/api/CurrentDataCrud/Create
        {
          "dataId": 0,
          "timeStamp": "2023-11-03T14:59:09.505Z",
          "temperature": 21,
          "humidity": 11,
          "condition": "Soleado",
          "windSpeed": 21,
          "id": 0
        }        
        */

        var current = {};
        current.timestamp = $("#dtTimeStampCurrent").val();
        current.temperature = $("#numTemperatureCurrent").val();
        current.humidity = $("#numHumidityCurrent").val();
        current.condition = $("#txtConditionCurrent").val();
        current.windseepd = $("#numWindSpeedCurrent").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, current, function () {
            console.log("Currenta Data created -->" + JSON.stringify(current));
        });

        console.log(JSON.stringify(current))
    }

    this.Update = function () {

        var current = {};
        current.id = $("#txtIdCurrent").val();
        current.timestamp = $("#dtTimeStampCurrent").val();
        current.temperature = $("#numTemperatureCurrent").val();
        current.humidity = $("#numHumidityCurrent").val();
        current.condition = $("#txtConditionCurrent").val();
        current.windseepd = $("#numWindSpeedCurrent").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService = "/Update";

        ctrlActions.PutToAPI(serviceRoute, current, function () {
            console.log("CurrentData update -->" + JSON.stringify(current));
        });

        console.log(JSON.stringify(current))
    } 

    this.Delete = function () {

        var current = {};
        current.id = $("#txtIdCurrent").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, current, function () {
            console.log("CurrentDate delete -->" + JSON.stringify(current));
        });

        console.log(JSON.stringify(current))
    }

    this.LoadTable = function () {

        var ctrlActions = new CurrentDataController();
        var urlService = ctrlActions.GetUrlApiService(this.ApiService + "/RetrieveAll");

        /*
        
        
        
        */

        var columns = {};
        columns[0] = { 'data': 'id' };
        columns[1] = { 'data': 'timeStamp' };
        columns[2] = { 'data': 'temperature' };
        columns[3] = { 'data': 'humidity' };
        columns[4] = { 'data': 'condition' };
        columns[5] = { 'data': 'windSpeed' };

        $("#tblListCurrentData").dataTable({
            "ajax": {
                "url": urlService,
                "dataSrc": ""
            },
            "columns": columns
        });

        $('#tblListCurrentData tbody').on('click', 'tr', function () {
            var row = $(this).closet('tr');

            var currentData = $('#tblListCurrentData').DataTable().row(row).data();
            $("#txtIdCurrent").value(currentData.id);
            $("#dtTimeStampCurrent").value(currentData.timestamp);
            $("#numTemperatureCurrent").value(currentData.temperature);
            $("#numHumidityCurrent").value(currentData.humidity);
            $("#txtConditionCurrent").value(currentData.condition);
            $("#numWindSpeedCurrent").value(currentData.windseepd);
        })
    }
}

$(document).ready(function () {
    var viewCont = new CurrentDataController();
    viewCont.InitView();
})
