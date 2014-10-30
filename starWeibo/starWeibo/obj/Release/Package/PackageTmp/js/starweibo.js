$(function () {
    /********换肤*********/
    $(".pifu1").click(function () {
        var a = $(this).attr("id");
        $(".yangshi").attr("href", "skin/css/change" + a +".css");
        //$.ajax({
        //    url: "webservice.asmx",
        //    data:{skin:"change"+a,userid:},
        //    datatype:JSON,
        //    type:POST,
        //    success:(function(D){
        //        alert(D);
        //    })

            

        //});
    });
    /*******************/

    /********皮肤下拉**********/
    $(".skinlist").mouseover(function () { 
        $(".skin").show();
    });
    $(".skinlist").mouseleave(function () {
        $(".skin").hide();
    });
    /************************/

   
});