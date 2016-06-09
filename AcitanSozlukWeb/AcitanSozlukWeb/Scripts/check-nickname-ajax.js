$(function () {

    var nickname_valid = false;

    function ShowNicknameValidity() {

        var txt = $("#Nickname");

        if (!nickname_valid) {
            txt.parent().find("span").text("Kullanıcı adı var").addClass("text-danger").removeClass("text-success");
        }
        else {
            txt.parent().find("span").text("Kullanıcı adı uygun").addClass("text-success").removeClass("text-danger");
        }
    }

    $("#Nickname").blur(function () {

        var text = $(this).val();

        $.ajax({
            url: "/Login/CheckNickname?nickname=" + text,
            method: "GET"
        }).done(function (d) {
            nickname_valid = !d.Value1;
            ShowNicknameValidity();
        });

    });

    $("#frmSignup").submit(function () {
        if (!nickname_valid) {
            ShowNicknameValidity();
            return false;
        }
    });

})