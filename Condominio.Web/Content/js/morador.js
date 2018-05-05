$(function ($, condominio) {

    var indiceColunas = {
        "nome": 0,
        "email": 1,
        "telefone": 2,
        "bloco": 3,
        "apartamento": 4,
        "acores": 5
    };

    function initDataTables() {
        var configuracao = condominio.dataTablesDefaults({
            columns: [
                { name: "nome", sortable: true, "width": "25%" },
                { name: "email", sortable: true, "width": "15%" },
                { name: "telefone", sortable: false, "width": "20%" },
                { name: "bloco", sortable: true, "width": "15%" },
                { name: "apartamento", sortable: true, "width": "15%" },                
                { name: "acoes", sortable: false, "width": "10px" },                
            ],
            order: [[indiceColunas.nome, "asc"]],            
        });

        return $("#tabela-moradores").dataTable(configuracao);
    }

    var datatable = initDataTables();

    $(document).on('click', '.delete-morador', function (e) {
        e.preventDefault();

        var tBody = $(this).closest('tbody');

        var postData = { 'id': $(this).data('id') };

        condominio.dialogs.confirmacao("Deseja excluir o registro selecionado?", function () {
            condominio.ajaxPost("Morador/Delete", postData, function (response) {
                if (response.sucesso == true) {
                    tBody.empty().html(response.html);
                    condominio.alerts.sucesso("Registro excluído com sucesso.");
                } else {
                    condominio.alerts.erro(response.mensagem);
                }
            });
        });
    });

    $(document).on('keyup', 'input[name=search]', function () {
        datatable.api().search(this.value).draw();
    });

}(jQuery, condominio));