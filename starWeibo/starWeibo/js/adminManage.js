$(function () {
    //基础模块控制
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
    //读取用户权限
    $(".select[fuzhi='0']").prop("checked", true);


    //全选
    $(".selectAll").click(function () {
        if ($(".selectAll").prop("checked") == true) {
            $(".selectOne").prop("checked", true);
        } else {
            $(".selectOne").prop("checked", false);
        }
    });
});