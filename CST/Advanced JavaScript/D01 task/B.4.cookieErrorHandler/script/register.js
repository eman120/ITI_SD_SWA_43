function init() { 
}
var date = new Date();

function go_to_welcome_page() {
        init();
    date.setDate(date.getDate() + 14);
    setCookie("number_of_visits", 0, date);
    //setCookie("number_of_visits", 0, date,44);
    //setCookie("number_of_visits");
    //setCookie(1, 0, date);
    //setCookie("number_of_visits", "0", date);
    //setCookie("number_of_visits", 0, 55);

    get_user_data();
    window.open("Welcome_page.html"); //go to welcome page 
}

function get_user_data()
{
        var user_name;
        var user_age;
        var user_gender;
        var fav_color;

        user_name = document.getElementById("name").value;
        user_age = document.getElementById("age").value;

        if (document.getElementById("f").checked)
        {
                user_gender = "female";
        }
        else if (document.getElementById("m").checked)
        {
                user_gender = "male";
        }

        color_list = document.getElementById("color");
        color_index = color_list.options.selectedIndex;
        fav_color = color_list[color_index].value;

        setCookie("user_name", user_name);
        setCookie("user_gender", user_gender);
        setCookie("user_age", user_age);
        setCookie("color", fav_color);
        console.log("user_name");
        console.log("user_gender");
        console.log("user_age");
        console.log("color");

}

function type_data()
{
        /*
        deleteCookie("number_of_visits");
        deleteCookie("user_name");
        deleteCookie("user_gender");
        deleteCookie("user_age");
        deleteCookie("color");*/
        deleteCookie("number_of_all_visits");

        date.setDate(date.getDate()+14);
        
                setCookie("number_of_visits", parseInt(getCookie("number_of_visits")) +1, date);
                //deleteCookie("number_of_visits");

        if (getCookie("user_gender") == "female")
        {
                document.getElementById("gender").src = "Images/2.jpg";
        }
        else if (getCookie("user_gender") == "male")
        {
                document.getElementById("gender").src = "Images/1.jpg";
        }

        getCookie("hello");
        // console.log(getCookie("color"));
        document.getElementById("user_data").innerHTML = "Welcome <span style = 'color:"+getCookie("color")+"'> " +getCookie("user_name")+" "+" </span> you Have entered this site <span style = 'color:"+getCookie("color")+"'> " + getCookie("number_of_visits") +" "+ " </span>  times :)" ;
        //document.getElementById("user_data").innerHTML = "Welcome <span style = 'color:"+getCookie("color" ,12)+"'> " +getCookie("user_name")+" "+" </span> you Have entered this site <span style = 'color:"+getCookie("color")+"'> " + getCookie("number_of_visits")+" "+ " </span>  times :)" ;
}