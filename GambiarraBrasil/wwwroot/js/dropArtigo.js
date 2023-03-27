$(document).ready(function () {
    $(".click-drop").click(function () {
        var artigoId = $(this).attr('artigo-id');
        console.log(artigoId);
        if (artigoId != '') {
            $.ajax({
                type: 'POST',
                url: "/MinhasPublicacoes/DropGetArtigo/" + artigoId,
                success: function (result) {
                    $("#modal-drop").html(result);
                }
            });
        }
    });
});