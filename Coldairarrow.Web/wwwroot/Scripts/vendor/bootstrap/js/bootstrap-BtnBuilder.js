//BtnBuilder类，用于构建表格中的按钮组
function BtnBuilder() {
    BtnBuilder.prototype.btnList = ['<div class="btn-group btn-group-sm">'];
};
BtnBuilder.prototype.btnList = [];
BtnBuilder.prototype._btnConfig = {
    name: '',
    icon: '',
    iconp: '',
    function: '',
    param: [],
    title: ''
};
BtnBuilder.prototype.AddBtn = function (options) {
    var _options = $.extend({}, this._btnConfig, options);

    var clickHtml = '';
    if (_options.function) {
        for (var i = 0; i < _options.param.length; i++) {
            _options.param[i] = "'" + _options.param[i] + "'";
        }
        clickHtml = 'onclick="' + _options.function + '(' + _options.param.join(',') + ')"';
    }

    var iconHtml = '';
    if (_options.icon) {
        iconHtml = '<span class="glyphicon ' + _options.icon + '" aria-hidden="true"></span>';
    } else if (_options.iconp) {
        iconHtml = '<span class="boton-reporte" aria-hidden="true"></span>';
    }

    var titleHtml = '';
    if (_options.title) {
        titleHtml = ' title="' + _options.title + '" ';
    }

    this.btnList.push('<button ' + clickHtml + titleHtml + ' data-toggle="tooltip" type="button" class="btn btn-default"  singleSelected=true>' + iconHtml + _options.name + '</button>');
};
BtnBuilder.prototype.build = function () {
    this.btnList.push('</div>');
    return this.btnList.join('');
};
