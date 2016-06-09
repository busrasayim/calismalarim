$(function () {

    // Bana sayfadaki tüm like-dislike class'lı div'leri bul.
    $("div.like-dislike > a").click(function () {
        // O an tıklanan a'nın href özelliğindeki değeri veren jquery kodu.
        var url = $(this).attr("href");
        var a = $(this);

        if (a.hasClass("discoloration05")) {
            url += "?current=false";
        }
        else {
            url += "?current=true";
        }

         console.log(url);

        $.ajax({
            url: url,
            method: "GET"
        }).done(function (obj) {

            //console.log(obj);

            if (obj.HasError == true) {

                swal({
                    title: "Bir Hata Oluştu!",
                    text: obj.Error,
                    timer: 3000,
                    showConfirmButton: false,
                    type: "error"
                });

                //alert(obj.Error);
                return false;
            }

            // d = true ise;
            if (obj.HasError == false) {
                //debugger;
                // $(this) bu bize xmlhttprequest = ajax request nesnesini verir. (a değil)
                //a.addClass("discoloration05");

                var span = a.find("span");

                if (span.hasClass("glyphicon-thumbs-up"))
                {
                    a.parent().find("a span.glyphicon-thumbs-down").parent().addClass("discoloration05");
                }
                else
                {
                    a.parent().find("a span.glyphicon-thumbs-up").parent().addClass("discoloration05");
                }

                a.parent().find("a span.glyphicon-thumbs-up").parent().attr("data-hint", obj.Value1);

                a.parent().find("a span.glyphicon-thumbs-down").parent().attr("data-hint", obj.Value2);

                a.toggleClass("discoloration05");
            }

        })

        return false;
    })

})