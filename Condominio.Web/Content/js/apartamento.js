$(function ($, condominio) {
    $(document).on('click', '.delete-apartamento', function (e) {
        e.preventDefault();

        var tBody = $(this).closest('tbody');

        var postData = { 'id': $(this).data('id') };

        condominio.dialogs.confirmacao("Deseja excluir o registro selecionado?", function () {
            condominio.ajaxPost("Apartamento/Delete", postData, function (response) {
                if (response.sucesso == true) {
                    tBody.empty().html(response.html);
                    condominio.alerts.sucesso("Registro excluído com sucesso.");
                } else {
                    condominio.alerts.erro(response.mensagem);
                }
            });
        });
    });
}(jQuery, condominio));