(function (){



var $sidebarAndAllContent=$("#sidebar,#all_content");


$("#sidebarToggle").on("click", function(){

    $sidebarAndAllContent.toggleClass("hide_sidebar"); 

    if($sidebarAndAllContent.hasClass("hide_sidebar"))
    {
       $(this).text("Show Menu");
    }else
    {
       $(this).text("Hide Menu");

    }


});











})();
