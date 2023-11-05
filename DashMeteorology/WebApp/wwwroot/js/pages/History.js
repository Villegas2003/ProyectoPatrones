function HistoryController() {

    this.ViewName = "History";
    this.ApiService = "HistoryCRUD";

    this.InitView = function () {

        console.log("History view init");

        $("#btnCreateHistory").click(function () {
            var hc = new HistoryController();
            hc.Create();
        })
        $("#btnUpdateHistory").click(function () {
            var hc = new HistoryController();
            hc.Update();
        })
        $("#btnDeleteHistory").click(function () {
            var hc = new HistoryController();
            hc.Delete();
        })

        //this.LoadTable();
    }

    this.Create = function () {
        /*
            EndPoint: https://localhost:7155/api/HistoryCRUD/Create
        {
          "historyId": 0,
          "date": "2023-11-03T15:02:07.576Z",
          "maxTemperature": 21,
          "minTemperature": 1,
          "condition": "Nubloso",
          "id": 0
        }
        */

        var history = {};
        history.date = $("#txtDateHis").val();
        history.maxTemperature = $("#numMaxTemperatureHis").val();
        history.minTemperature = $("#numMinTemperatureHis").val();
        history.condition = $("#txtConditionHis").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, history, function () {
            console.log("History created -->" + JSON.stringify(history));
        });
        console.log(JSON.stringify(history))
    }

    this.Update = function () {

        var history = {};
        history.id = $("#txtIdHis").val();
        history.date = $("#txtDateHis").val();
        history.maxTemperature = $("#numMaxTemperatureHis").val();
        history.minTemperature = $("#numMinTemperatureHis").val();
        history.condition = $("#txtConditionHis").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, history, function () {
            console.log("History Update -->" + JSON.stringify(history));
        });
        console.log(JSON.stringify(history))
    }

    this.Delete = function () {

        var history = {};
        history.id = $("#txtIdHis").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, history, function () {
            console.log("History delete -->" + JSON.stringify(history));
        });
        console.log(JSON.stringify(history))
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

        $("#tblListHistory").dataTable({
            "ajax": {
                "url": urlService,
                "dataSrc": ""
            },
            "columns": columns
        });

        $('#tblListHistory tbody').on('click', 'tr', function () {

            var row = $(this).closet('tr');

            var historyData = $('#tblListHistory').DataTable().row(row).data();
            $("#txtIdHis").value(historyData.id);
            $("#txtDateHis").value(historyData.date);
            $("#numMaxTemperatureHis").value(historyData.maxTemperature);
            $("#numMinTemperatureHis").value(historyData.minTemperature);
            $("#txtConditionHis").value(historyData.condition);
        })
    }
}

$(document).ready(function () {
    var viewCont = new HistoryController();
    viewCont.InitView();
})
