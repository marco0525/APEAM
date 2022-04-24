// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#Cantidad").click(function () {
        $("#Total").val(Number($("#Cantidad").val()) * Number($("#CostoUnitario").val()));
    });
    $("#CostoUnitario").click(function () {
        $("#Total").val(Number($("#Cantidad").val()) * Number($("#CostoUnitario").val()));
    });
    $("submit").click(function () {
        $("#Total").val(Number($("#Cantidad").val()) * Number($("#CostoUnitario").val()));
    });
});