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

    $(document).on('click', 'a.add-morador', function (e) {
        e.preventDefault();

        var table = $('table.table-moradores');

        condominio.ajaxPost("Apartamento/AddMorador", { 'id': $('#ListaMoradores').val() }, function (response) {
            if (response.sucesso == true) {
                table.find('tfoot').remove();
                table.find('tbody').remove();
                table.append(response.html);

                table.find('input[type="radio"]').iCheck({
                    checkboxClass: "icheckbox_minimal-blue",
                    radioClass: "iradio_minimal-blue"
                });

                condominio.alerts.sucesso("Morador adicionado com sucesso.");
            } else {
                condominio.alerts.erro(response.mensagem);
            }
        });
    });

    $(document).on('click', 'a.delete-morador', function (e) {
        e.preventDefault();

        var table = $('table.table-moradores');

        condominio.ajaxPost("Apartamento/DeleteMorador", { 'id': $(this).data('id') }, function (response) {
            if (response.sucesso == true) {
                table.find('tfoot').remove();
                table.find('tbody').remove();
                table.append(response.html);

                condominio.alerts.sucesso("Morador excluído com sucesso.");
            } else {
                condominio.alerts.erro(response.mensagem);
            }
        });
    });

    $(document).on('ifChecked', 'input[name=Responsavel]', function () {                                        

        condominio.ajaxPost("Apartamento/MoradorResponsavel", { 'id': $(this).val() }, function (response) {
            if (response.sucesso == false) {                
                condominio.alerts.erro(response.mensagem);                  
            }
        });
    });

}(jQuery, condominio));