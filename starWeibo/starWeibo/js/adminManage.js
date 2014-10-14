$(function () {
    $(".Report").click(function () {
        $(".Right1").show();
        $(".Right2").hide();
        $(".Right3").hide();
    });
    $(".UserManages").click(function () {
        $(".Right2").show();
        $(".Right1").hide();
        $(".Right3").hide();
    });
    $(".Send").click(function () {
        $(".Right3").show();
        $(".Right1").hide();
        $(".Right2").hide();
    });
});