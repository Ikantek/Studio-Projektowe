$(function () {
    $(".btn-table").click(function (e) {
        var number = $(this).data("number");
        $(".table-exercises").hide();
        $('.table-exercises[data-table-id=' + number + ']').show();
    });
});
