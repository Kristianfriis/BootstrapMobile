var createBlazorOffcanvas = function () {
    return {
        dotNetReference: null,
        $modalNode: null,
        init: function (dotNetReference, elementRef) {
            this.dotNetReference = dotNetReference;
            this.$modalNode = new bootstrap.Offcanvas(elementRef);
            //this.$modalNode.carousel();
            //this.$modalNode.on('slide.bs.carousel', function (event) {
            //    dotNetReference.invokeMethod("OnSlide", event.direction, event.from, event.to);
            //});
            //this.$modalNode.on('slid.bs.carousel', function (event) {
            //    dotNetReference.invokeMethod("OnSlid", event.direction, event.from, event.to);
            //});
        },
        toggleModal: function () {
            this.$modalNode.toggle();
        },
        dispose: function () {
            this.dotNetReference = null;
            this.$modalNode = null;
        }
    }
}