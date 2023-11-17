function WriteDB() {
    var tabletab = document.getElementById('tabb');

    var isValid = true;

    for (var i = 1; i <= tabletab.rows.length; i++) {

        if (($('#Uroven_' + Number(i)).val() == "") || ($('#Uroven_' + Number(i)).val() == "Упс!")) {
            $('#Uroven_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#Uroven_' + Number(i)).css('border-color', 'lightgrey');

        }
        if ($('#V20_' + Number(i)).val() == "" || $('#Uroven_' + Number(i)).val() == "Упс!") {
            $('#V20_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#V20_' + Number(i)).css('border-color', 'lightgrey');
        }

        if ($('#Temperat_' + Number(i)).val() == "" || $('#Uroven_' + Number(i)).val() == "Упс!") {
            $('#Temperat_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#Temperat_' + Number(i)).css('border-color', 'lightgrey');
        }

        if ($('#V_' + Number(i)).val() == "" || $('#Uroven_' + Number(i)).val() == "Упс!") {
            $('#V_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#V_' + Number(i)).css('border-color', 'lightgrey');
        }

        if ($('#Plotnost_' + Number(i)).val() == "" || $('#Uroven_' + Number(i)).val() == "Упс!") {
            $('#Plotnost_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#Plotnost_' + Number(i)).css('border-color', 'lightgrey');
        }

        if ($('#massa_' + Number(i)).val() == "" || $('#Uroven_' + Number(i)).val() == "Упс!") {
            $('#massa_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#massa_' + Number(i)).css('border-color', 'lightgrey');
        }

        if ($('#UrovH2O_' + Number(i)).val() == "" || $('#UrovH2O_' + Number(i)).val() == "Упс!") {
            $('#UrovH2O_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#UrovH2O_' + Number(i)).css('border-color', 'lightgrey');
        }

        if ($('#VH2O_' + Number(i)).val() == "" || $('#VH2O_' + Number(i)).val() == "Упс!") {
            $('#VH2O_' + Number(i)).css('border-color', 'Red');
            isValid = false;
        }
        else {
            $('#VH2O_' + Number(i)).css('border-color', 'lightgrey');
        }

    }
    if (isValid == false) {
        return false;
    }

    for (var i = 1; i <= tabletab.rows.length; i++) {
        var data = {
            'LocID': $('#LocID_' + Number(i)).val(),
            'IDRez': $('#ID_' + Number(i)).val(),
            'Uroven': $('#Uroven_' + Number(i)).val(),
            'V20': $('#V20_' + Number(i)).val(),
            'Temperat': $('#Temperat_' + Number(i)).val(),
            'V': $('#V_' + Number(i)).val(),
            'Plotnost': $('#Plotnost_' + Number(i)).val(),
            'massa': $('#massa_' + Number(i)).val(),
            'UrovH2O': $('#UrovH2O_' + Number(i)).val(),
            'VH2O': $('#VH2O_' + Number(i)).val()
        };

        $.ajax({
            url: "/Home/WriteDB",
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            data: JSON.stringify(data),
            dataType: "html",
            success: function (result) {
                $('#ServicesModalContent').html(result);
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
    //---------------------------------------------------------------
    $.ajax({
        url: "/Home/ModalDB",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        //data: JSON.stringify(data),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
            $('#ServicesModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
    //---------------------------------------------------------------
//--------------------------------//
function GetDB()
{
        $.ajax({
        url: "/Home/ModalDB",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        //data: JSON.stringify(data),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
            $('#ServicesModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });

        
}

// Редактирование члена комиссии //

function KomissiyaEdit(ID) {
    $.ajax({
        url: "/Home/KomissiyaEdit/" + ID,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
            $('#ServicesModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    })
}
//-------------------------//
// Сохранение редактирования члена комиссии //

function KomissiyaEditSave() {

    var isValid = true;

    if ($('#Doljnost').val() == "") {
        $('#Doljnost').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Doljnost').css('border-color', 'lightgrey');
    }

    if ($('#FIO').val() == "") {
        $('#FIO').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#FIO').css('border-color', 'lightgrey');
    }


    if (isValid == false) {
        return false;
    }

    var data = {

        'ID': $('#ID').val(),
        'Nazn': $(Nazn).val(),
        'Doljnost': $('#Doljnost').val(),
        'FIO': $('#FIO').val(),

    };

    $.ajax({
        url: "/Home/KomissiyaEditSave",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(data),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });

}

//-------Добавление члена комиссии--------------//
function AddKomissiya() {
    $.ajax({
        url: "/Home/AddKomissiya/",
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
            $('#ServicesModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    })
}

//-------Сохранение добавления члена комиссии----------//
function KomissiyaSave() {

    var isValid = true;
    if ($('#komis').val() == "Выберите филиал") {
        $('#komis').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#komis').css('border-color', 'lightgrey');
    }

    if ($('#Doljnost').val() == "") {
        $('#Doljnost').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Doljnost').css('border-color', 'lightgrey');
    }

    if ($('#FIO').val() == "") {
        $('#FIO').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#FIO').css('border-color', 'lightgrey');
    }


    if (isValid == false) {
        return false;
    }

    var data = {
        //'ID': ID,
        'location': $('#komis').val(),
        'Nazn': $('#Nazn').val(),
        'Doljnost': $('#Doljnost').val(),
        'FIO': $('#FIO').val()

    };

    $.ajax({
        url: "/Home/KomissiyaSave",
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(data),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalContent').html(result);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });

}
//--------------------------------//
//--------------------------------//
// Удаление члена//

function DeletePodpis(ID) {
    $.ajax({
        url: "/Home/DeletePodpis/" + ID,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalDeleteContent').html(result);
            $('#ServicesModalDelete').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
//-----------------------------//
//Подтверждение удаления члена //
function DeletePodpisOK(ID) {


    $.ajax({
        url: "/Home/DeletePodpisOK/" + ID,
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        data: JSON.stringify(),
        dataType: "html",
        success: function (result) {
            $('#ServicesModalDeleteContent').html(result);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//----------Отчет в PDF ------------------------------------------------
function Report() {
    var stringhref = "Report?";

    stringhref += "dat=" + $('#datapicker').val(); /*+ "&" + "IDPodrPr=" + $('#pppp').val() + "&" + "IDPodrOtd=" + $('#otdel').val() + "&" + "IDPodrPodr=" + $('#gruppa').val() + "&" + "IDPodrUch=" + $('#uch').val();*/
    window.location = stringhref;
    //window.location = "/Home/ExportGroup/";
}
//----------------------------------------------------------