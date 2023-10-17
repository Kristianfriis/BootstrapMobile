var createBlazorOffcanvas = function () {
    return {
        dotNetReference: null,
        $modalNode: null,
        init: function (dotNetReference, elementRef) {
            this.dotNetReference = dotNetReference;
            this.$modalNode = new bootstrap.Offcanvas(elementRef);
            //this.$modalNode.toggle();
        },
        toggleModal: function () {
            this.$modalNode.toggle();
        },
        closeModal: function () {
            this.$modalNode.hide();
        },
        dispose: function () {
            this.dotNetReference = null;
            this.$modalNode = null;
        }
    }
}