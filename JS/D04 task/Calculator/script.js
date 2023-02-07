var num ="";
var op = "";

function EnterNumber(number)
{
    if(num == "")
    {
        document.querySelector("#Answer").value = "";
    }
    document.querySelector("#Answer").value += number;
    num+= number;
}

function EnterOperator(operator)
{
    if(num == "")
    {
        document.querySelector("#Answer").value = "";
        num += result;
    }
    op += operator;
    document.querySelector("#Answer").value += operator;
    num += ",";
    op += ",";
}

var result = 0;

function EnterEqual()
{
    num = num.split(",");
    for(var i = 0 ; i <num.length ; i++)
    {
        num[i]= parseFloat(num[i]);
    }
    result += num[0]; 

    op = op.split(",");
    for(var j = 0 ; j <num.length ; j++)
    {
        if (op[j] == "+")
        {
            result += num[j+1];
        }
        else if (op[j] == "-")
        {
            result -= num[j+1];
        }
        else if (op[j] == "*")
        {
            result *= num[j+1];
        }
        else if (op[j] == "/")
        {
            result /= num[j+1];
        }
    }

    document.querySelector("#Answer").value = result;
    num ="";
    op = "";
    result = 0;
    //EnterClear();
}

function EnterClear()
{
    document.querySelector("#Answer").value = "";
    num ="";
    op = "";
    result = 0;
}