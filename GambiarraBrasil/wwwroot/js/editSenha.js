$(document).ready(function () {
    $('.click-senha').click(function () {
        var userId = $(this).attr('user-id');
        console.log(111)
        $.ajax({
            Type: 'GET',
            url: '/Usuario/ReturnModalSenha',
            success: function (result) {
                $("#modal-senha").html(result);
            }
        });
    });
})