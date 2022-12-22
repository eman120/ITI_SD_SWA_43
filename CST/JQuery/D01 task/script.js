$("#about").click(
    function () {
        $("#aboutDiv").show();

        $("#aboutDiv").css({ "width": "400px", "height": "200px", "margin-left": "35%", "margin-top": "10%", "box-shadow": "0 9px 9px 0 rgb(201, 187, 187)" });
        $("#aboutDiv").html("<h3>This is our about div. welcome</h3>");

        $("#gallaryDiv").hide();
        $("#servicesDiv").hide();
        $("#complainDiv").hide();
    }
)

$("#gallary").click(
    function () {
        $("#gallaryDiv").show(1000);

        $("#aboutDiv").hide();
        $("#servicesDiv").hide();
        $("#complainDiv").hide();
    }
)

var index = 1;
$("#right").click(
    function(){
        if(index < 8){
            $("#image").attr("src" , "Images/" + ++index + ".jpg");
            //index++;
        }
        else{
            index = 0;
        }
    }
)

$("#left").click(
    function(){
        if(index == 1){
            index = 9;
        }
        else{
            $("#image").attr("src" , "Images/" + --index + ".jpg");
            //index--;
        }
    }
)

$("#services").click(
    function () {
        $("#servicesDiv").slideDown(1000);


        $("#aboutDiv").hide();
        $("#gallaryDiv").hide();
        $("#complainDiv").hide();
    }
)

$("#complain").click(
    function () {
        $("#complainDiv").show();
        $("#complainDiv").css({ "width": "400px", "height": "200px", "margin-left": "35%", "margin-top": "10%", "box-shadow": "0 9px 9px 0 rgb(201, 187, 187)" });
    
        $("#aboutDiv").hide();
        $("#gallaryDiv").hide();
        $("#servicesDiv").hide();
    }
)

$("#send").click(
    function()
    {
        $("#complainDiv").hide();
        $("#complainValues").show();
        $("#complainValues").css({ "width": "400px", "height": "200px", "margin-left": "35%", "margin-top": "10%", "box-shadow": "0 9px 9px 0 rgb(201, 187, 187)" });
        $("#nam").html("<b>" + $("#name").val() + "</b>")
        $("#ema").html("<b>" + $("#email").val() + "</b>")
        $("#pho").html("<b>" + $("#phone").val() + "</b>")
        $("#comp").html("<b>" + $("#complainText").val() + "</b>")
    }
)

$("#edit").click(
    function()
    {
        $("#complainDiv").show();
        $("#complainValues").hide();
    }
)

