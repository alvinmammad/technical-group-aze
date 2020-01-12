$(document).ready(function () {
    $("#form-product").on('submit', function (e) {
        e.preventDefault();
        console.log($("PhotoProduct"));
    });
    var array = [];
    $("#Photo").change(function () {
        array = [];
        $(".photos li").remove();
        var files = $(this).get(0).files;
        for (var file of files) {
            array.push(file);
        }
        var formData = new FormData();
        for (var arr of array) {
            formData.append("Photos[]", arr);
        }
        $.ajax({
            url: "/TechnicalGroupAdmin/Products/AddPhoto/",
            data: formData,
            cache: !1,
            processData: !1,
            contentType: !1,
            dataType: "json",
            type: "post",
            success: function (response) {
                if (response.status === 200) {
                    for (var i = 0; i < response.data.length; i++) {
                        var listItem = `<li><i class="fas fa-times"></i><img src="${response.data[i].src}" data-name="${response.data[i].name}"></li>`;
                        var option = `<option selected value="${response.data[i].name}">${response.data[i].name}</option>`;
                        $("select[name='PhotoNames']").append(option);
                        $(".photos").append(listItem);
                    }
                }
            }
        });
    });
    $(".photos").on("click", "li i", function () {
        var listItem = $(this).parent();
        var obj = {
            filename: $(listItem.find("img")).data("name")
        };
        for (var i = 0; i < array.length; i++) {
            if (array[i].name === $(listItem.find("img")).data("name")) {
                array.splice(i, 1);
            }
        }
        $(this).parent().remove();
        $("select[name='PhotoNames'] option[value='" + $(listItem.find("img")).data("name") + "']").remove();
        $.ajax({
            url: "/TechnicalGroupAdmin/Products/DeletePhoto/",
            data: obj,
            dataType: "json",
            type: "post",
            success: function (response) {
                if (response.status === 200) {
                    toastr.success('Şəkil silindi');
                } else {
                    toastr.error('Şəkil silinmədi');
                }
            }
        })
    });
    var projectsarray = [];
    $("#PhotoProject").change(function () {
        projectsarray = [];
        $(".photosProject li").remove();
        var filesProjects = $(this).get(0).files;
        for (var fileProject of filesProjects) {
            projectsarray.push(fileProject);
        }
        var projectsformData = new FormData();
        for (var projectarr of projectsarray) {
            projectsformData.append("ProjectPhotos[]", projectarr);
        }
        $.ajax({
            url: "/TechnicalGroupAdmin/Projects/AddPhoto/",
            data: projectsformData,
            cache: !1,
            processData: !1,
            contentType: !1,
            dataType: "json",
            type: "post",
            success: function (response) {
                if (response.status === 200) {
                    for (var i = 0; i < response.data.length; i++) {
                        var ProjectlistItem = `<li><i class="fas fa-times"></i><img src="${response.data[i].src}" data-name="${response.data[i].name}"></li>`;
                        var Projectsoption = `<option selected value="${response.data[i].name}">${response.data[i].name}</option>`;
                        $("select[name='ProjectsPhotoNames']").append(Projectsoption);
                        $(".photosProject").append(ProjectlistItem);
                    }
                }
            }
        })
    });
    $(".photosProject").on("click", "li i", function () {
        var listItem = $(this).parent();
        var obj = {
            filename: $(listItem.find("img")).data("name")
        };
        for (var i = 0; i < array.length; i++) {
            if (array[i].name === $(listItem.find("img")).data("name")) {
                array.splice(i, 1)
            }
        }
        $(this).parent().remove();
        $("select[name='ProjectsPhotoNames'] option[value='" + $(listItem.find("img")).data("name") + "']").remove();
        $.ajax({
            url: "/TechnicalGroupAdmin/Projects/DeletePhoto/",
            data: obj,
            dataType: "json",
            type: "post",
            success: function (response) {
                if (response.status === 200) {;
                    toastr.success('Şəkil silindi');
                } else {
                    toastr.error('Şəkil silinmədi');
                }
            }
        });
    });

    String.prototype.removeAcento = function () {
        var text = this.toLowerCase();
        text = text.replace(new RegExp('[ÁÀÂÃ]', 'gi'), 'a');
        text = text.replace(new RegExp('[ÉÈÊ]', 'gi'), 'e');
        text = text.replace(new RegExp('[ÍÌÎ]', 'gi'), 'i');
        text = text.replace(new RegExp('[ÓÒÔÕ]', 'gi'), 'o');
        text = text.replace(new RegExp('[ÚÙÛÜ]', 'gi'), 'u');
        text = text.replace(new RegExp('[Ç]', 'gi'), 'c');
        text = text.replace(new RegExp('[Ə]', 'gi'), 'e');
        text = text.replace(new RegExp('[I]', 'gi'), 'i');
        text = text.replace(new RegExp('[ı]', 'gi'), 'i');
        return text;
    };

    String.prototype.slugify = function () {
        return this.toString().toLowerCase().removeAcento().trim()
            .replace(/\s+/g, '-')           // Replace spaces with -
            .replace(/[^\w\-]+/g, '')       // Remove all non-word chars
            .replace(/\-\-+/g, '-')         // Replace multiple - with single -
            .replace(/^-+/, '')             // Trim - from start of text
            .replace(/-+$/, '');            // Trim - from end of text
    };

    $("input[data-type='slug-source']").blur(function () {
        $("input[data-type='slug-input']").val($(this).val().slugify());
    });
});