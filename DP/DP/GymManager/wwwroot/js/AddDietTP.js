$(function () {
    $(".upload-file").change(function (e) {
        var number = $(this).data("userid");
        $('.formSubmit-' + number).click();
    });
});
async function AJAXSubmit(oFormElement) {
    const formData = new FormData(oFormElement);
    try {
        const response = await fetch(oFormElement.action, {
            method: 'POST',
            body: formData
        });

        if (response.ok) {
            window.location.href = '/panel-managera/dodaj-diete';
        }
    } catch (error) {
        console.error('Error:', error);
    }
}