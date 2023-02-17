(function () {
    $(function () {

        var _createOrEditModal = new app.ModalManager({
            viewUrl: '/Category/CreateOrEditModal',
            scriptUrl: '',
            modalClass: ''
        });

        $('#CreateCategoryButton').click(function () {
            _createOrEditModal.open();
        });
    });
})();