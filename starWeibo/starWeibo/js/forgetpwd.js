$(function () {
    $(".pass-button-submit").click(function () {
        $(".forgotse1").hide();
        $(".forgotse2").show();
        $(".mod-sub-list1").removeClass("list1-active");
        $(".mod-sub-list2").addClass("list2-active");
    });
    $(".pass-button-submit1").click(function () {
        $(".forgotse2").hide();
        $(".forgotse3").show();
        $(".mod-sub-list2").removeClass("list2-active");
        $(".mod-sub-list3").addClass("list3-active");
    });
});