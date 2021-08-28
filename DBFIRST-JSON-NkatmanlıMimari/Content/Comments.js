const commentItemTemplate = "<tr> <td>{{Id}}</td> <td>{{Comments}}</td> <td><button class='btn btn-danger' onclick='helper.RemoveComments(\"{{Id}}\", this)'>Sil</button></td> </tr>";

$(() => {

    helper.TableLoad();

})
const helper = {
    Table: $("#Comments-table"),
    TableLoad: function () {

        $(helper.Table).children("tbody").html("Yükleniyor...");

        var productId = $("#ProductId").val();

        $.get("/Home/GetComments/" + productId, function (response) {

            $(helper.Table).children("tbody").html("");

            console.log(response);

            response.forEach(Comment => {

                $(helper.Table).children("tbody").append(commentItemTemplate
                    .replace("{{Id}}", Comment.ID)
                    .replace("{{Comments}}", Comment.Comments)
                    .replace("{{Id}}", Comment.ID)
                )

            });
        })
    },

    RemoveComments: function (id, elem) {

        let url = "/Home/DeleteComments"
        let model = {
            ID: id,
            
        }
        $.post(url, model, function (res) {
            if (res) {
                helper.TableLoad();
            }
        })

    },
    AddComment: function () {
        let url = "/Home/AddComments/";
        let model = {            
            Comments: $("#Comments").val(),
            ProductId: $("#ProductId").val(),
        }

        $.post(url, model, function (res) {
            if (res) {
                helper.TableLoad();
            }
        })
    }



}
