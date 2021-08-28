const productItemTemplate = "<tr> <td>{{Id}}</td> <td>{{Name}}</td> <td><button class='btn btn-primary' onclick='helper.UpdateProductModalOpen(\"{{Id}}\",\"{{Name}}\", this)'>Güncelle</button><button class='btn btn-danger' onclick='helper.RemoveProduct(\"{{Id}}\",\"{{Name}}\", this)'>Sil</button><a href=\"{{Link}}\" class=\"btn btn-primary\">Görüntüle </a></td> </tr>";
              
$(() => {

    helper.TableLoad();
    
})

const helper = {
    Table: $("#product-table"),
    TableLoad: function () {

        $(helper.Table).children("tbody").html("Yükleniyor...");

        $.get("/Home/GetProducts", function (response) {

            $(helper.Table).children("tbody").html("");

            console.log(response);

            response.forEach(product => {

                $(helper.Table).children("tbody").append(productItemTemplate
                    .replace("{{Id}}", product.ID)
                    .replace("{{Name}}", product.ProductName)
                    .replace("{{Id}}", product.ID)
                    .replace("{{Name}}", product.ProductName)
                    .replace("{{Id}}", product.ID)
                    .replace("{{Name}}", product.ProductName)
                    .replace("{{Link}}", "/Home/ProductDetail/" + product.ID))

            });
        })

    },
    RemoveProduct: function (id, name, elem) {

        let url = "/Home/DeleteProducts/"
        let model = {
            ID: id,
            ProductName: name
        }
        $.post(url, model, function (res) {
            if (res) {
                helper.TableLoad();
            }
        })
    },
    AddProduct: function () {

        var model = { ProductName: $("#productName").val() };

        $.post("/Home/AddProducts", model, function (res) {

            if (res) {
                $("#productName").val("");
                helper.TableLoad();
            }

        });

    },
    UpdateProduct: function () {

        let ıd = $("#updateProductId").val();
        let name = $("#updateProductName").val();
        let model = {

            ID: ıd ,
            ProductName: name

        }
        $.post("/Home/UpdateProduct", model, function (res) {

            if (res) {
              
                    //window.location.href = "../Home/Index"; sayfayı yeniler
                helper.TableLoad();
                $('#productModal').modal('hide')

            }

        });
    },
    UpdateProductModalOpen: function (id, name, elem) {


        $("#updateProductId").val(id);
        $("#updateProductName").val(name);


        $('#productModal').modal('show')

    }
};