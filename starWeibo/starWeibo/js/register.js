$(function () {
    //alert("dws");
    $(".nicheng").click(function () {
        $(".ts1").show();
        $(".ts2").hide();
        $(".ts3").hide();
        $(".ts4").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts1").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts1").hide();
    });
    $(".youxiang").click(function () {
        $(".ts2").show();
        $(".ts1").hide();
        $(".ts3").hide();
        $(".ts4").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts2").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts2").hide();
    });
    $(".mima").click(function () {
        $(".ts3").show();
        $(".ts2").hide();
        $(".ts1").hide();
        $(".ts4").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts3").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts3").hide();
    });
    $(".queren").click(function () {
        $(".ts4").show();
        $(".ts2").hide();
        $(".ts3").hide();
        $(".ts1").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts4").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts4").hide();
    });
    $(".yanzhengma").click(function () {
        $(".ts5").show();
        $(".ts2").hide();
        $(".ts3").hide();
        $(".ts4").hide();
        $(".ts1").hide();
        return false;
    });
    $(".ts5").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts5").hide();
    });
});