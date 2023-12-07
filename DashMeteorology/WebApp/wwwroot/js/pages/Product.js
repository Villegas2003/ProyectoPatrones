function ProductController() {
    this.ViewName = "Product";
    this.ApiService = "ProductCRUD";

    this.InitView = function () { 

        console.log("ForeCast view init");

        $("#btnCreateProduct").click(function () {
            var fc = new ProductController();
            fc.Create();
        })
        $("#btnUpdateProduct").click(function () {
            var fc = new ProductController();
            fc.Update();
        })
        $("#btnDeleteProduct").click(function () {
            var fc = new ProductController();
            fc.Delete();
        })

        //This.LoadTable();
    }

    this.Create = function (){

        /*
            EndPoint: https://localhost:7155/api/ProductCRUD/Create
        {
            "idProduct": 0,
            "name": "Robot",
            "price": 5000,
            "parts": "Piezas",
            "category": "Toys",
            "id": 0
        }
        */

        var product = {};
        product.name = $("#txtName").val();
        product.price = $("#numPrice").val();
        product.parts = $("#txtParts").val();
        product.category = $("#txtCategory").val(); 

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Create";

        ctrlActions.PostToAPI(serviceRoute, product, function () {
            console.log("Product Create -->" + JSON.stringify(product));
        });
        console.log(JSON.stringify(product))
    }

    this.Update = function () {

        var product = {};
        product.idProduct = $("#txtId").val();
        product.name = $("#txtName").val();
        product.price = $("#numPrice").val();
        product.parts = $("#txtParts").val();
        product.category = $("#txtCategory").val(); 

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Update";

        ctrlActions.PutToAPI(serviceRoute, product, function () {
            console.log("Product Update -->" + JSON.stringify(product));
        });
        console.log(JSON.stringify(product))
    }

    this.Delete = function () {

        var product = {};
        product.idProduct = $("#txtId").val();

        var ctrlActions = new ControlActions();
        var serviceRoute = this.ApiService + "/Delete";

        ctrlActions.DeleteToAPI(serviceRoute, product, function () {
            console.log("ForeCast Delete -->" + JSON.stringify(product));
        });
        console.log(JSON.stringify(product))
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

    //    $("#tblListForeCast").dataTable({
    //        "ajax": {
    //            "url": urlService,
    //            "dataSrc": ""
    //        },
    //        "columns": columns
    //    });

    //    $('#tblListForeCast tbody').on('click', 'tr', function () {
    //        var row = $(this).closet('tr');

    //        var foreData = $('#tblListForeCast').DataTable().row(row).data();
    //        $("#txtIdFore").value(foreData.id);
    //        $("#txtDateFore").value(foreData.date);
    //        $("#numMaxTemperatureFore").value(foreData.maxTemperature);
    //        $("#numMinTemperatureFore").value(foreData.minTemperature);
    //        $("#txtConditionFore").value(foreData.condition);


    //    })
    //}
}

$(document).ready(function () {
    var viewCont = new ProductController();
    viewCont.InitView();
})
