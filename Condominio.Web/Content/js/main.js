var condominio = condominio || {};

$(function ($, condominio) {

    function ajaxPost(action, data, callback, errorCallback) {
        var request = $.ajax({
            url: baseUrl(action),
            contentType: 'application/json; charset=utf-8',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data),
            beforeSend: function () { condominio.requisicao.exibirCarregando(); }
        });

        request.done(function (serverData) {

            condominio.requisicao.ocultarCarregando();

            if (typeof callback === 'function') {
                callback(serverData);
            }
        });

        request.fail(function (jqXHR, textStatus, errorThrown) {
            var mensagem = 'Ocorreu um erro durante sua solicitação.<br /><br />';
            var status = jqXHR.status;

            if (textStatus != 'error') {
                mensagem += '<small>' + status + ': ' + textStatus + '</small>';
            }
            else if (errorThrown) {
                mensagem += '<small>' + status + ': ' + errorThrown + '</small>';
            }

            condominio.dialogs.erro(mensagem, function () {
                if (typeof errorCallback === 'function') {
                    errorCallback();
                }
            });
        });
    }

    condominio.ajaxPost = ajaxPost;

    function baseUrl(action) {
        return BASEURL + action;
    }

    function confirmDialog(mensagem, onOK, onCancel) {
        alertify.confirm().setting({
            'labels': { ok: 'Sim', cancel: 'Não' },
            'closableByDimmer': false,
            'basic': false,
            'autoReset': true,
            'title': '<div style="padding: 2px; border-bottom: 1px solid #666">Confirmação</div>',
            'message': '<div class="media"><div class="media-left media-top"><i class="fa fa-2x fa-question-circle" style="color: #66c4de"></i></div><div class="media-body">' + mensagem + '</div></div>',
            'onok': function () { if (typeof onOK === 'function') onOK() },
            'oncancel': function () { if (typeof onCancel === 'function') onCancel() }
        }).show();
    }

    function errorDialog(mensagem, onOK) {
        var alert = alertify.alert();

        alert.setting({
            'labels': { ok: 'Fechar' },
            'closableByDimmer': false,
            'autoReset': true,
            'basic': false,
            'title': '<div style="padding: 2px; border-bottom: 1px solid #666">Erro</div>',
            'onok': function () {
                if (typeof onOK === 'function') {
                    onOK();
                }
                alert.close();
            },
            'message': '<div class="media"><div class="media-left media-top"><i class="fa fa-2x fa-exclamation-circle" style="color: red"></i></div><div class="media-body">' + mensagem + '</div></div>',
        }).show();
    }

    condominio.dialogs = {
        confirmacao: confirmDialog,
        erro: errorDialog
    };

    function sucesso(mensagem) {
        alertify.success(mensagem).dismissOthers();
    }

    function erro(mensagem) {
        alertify.error(mensagem).dismissOthers();
    }

    condominio.alerts = {
        sucesso: sucesso,
        erro: erro
    };

    condominio.requisicao = condominio.requisicao || (function () {
        var loadingOverlay = $('<div class="modal hidden" data-backdrop="static" tabindex="-1" id="loadingModal"><div class="modal-dialog modal-sm"><div class="modal-content"><span style="padding: 20px; font-size: 1.2em; font-weight: bold;"><i class="fa fa-cog fa-spin"></i> Por favor aguarde...</span></div></div></div>');

        return {
            exibirCarregando: function () {
                loadingOverlay.prependTo("body").removeClass("hidden").modal();
            },
            ocultarCarregando: function () {
                loadingOverlay.modal('hide');
            }
        };
    })();

}(jQuery, condominio));