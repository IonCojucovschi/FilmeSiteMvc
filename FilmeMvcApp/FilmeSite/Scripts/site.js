(function (){
    
var $sidebarAndAllContent=$("#sidebar,#all_content");


$("#sidebarToggle").on("click", function(){

    $sidebarAndAllContent.toggleClass("hide_sidebar"); 

    if($sidebarAndAllContent.hasClass("hide_sidebar"))
    {
       $(this).text(">");
    }else
    {
       $(this).text("<");

    }
});

//var $paginationContent=$("disabled, PagedList-ellipses");

//$paginationContent.toggleClass("pagination");









})();
