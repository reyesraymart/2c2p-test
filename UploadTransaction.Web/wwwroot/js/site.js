$('.custom-file-input').on('change', function () {
    //get the file name
    var fileName = $(this).val().split("\\").pop();
   // $(this).next('.form-control-file').addClass("selected").html(fileName);
    //replace the "Choose a file" label
    $(this).next('.custom-file-label').html(fileName);
})