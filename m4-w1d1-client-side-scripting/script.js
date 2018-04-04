function sumDouble(x, y) {

    const z = x + y;

    if(x == y) {
        return z * 2;
    }

    return z;

}

function hasTeen(x, y, z,)
{
    if(x >= 12 && x <= 19 || y >= 12 && y <= 19 || z >= 12 && z <= 19)
    {
        return true;
    }
    else{
        return false;
    }
}

function lastDigit(x, y)
{
  
    if(x % 10 == y % 10)
    {
        return true;
    }
    else{
        return false;
    }
}

function seeColor(str)
{
    if(str.indexOf("red") == 0)
    {
        return "red";
    }
    if(str.indexOf("blue") == 0)
    {
        return "blue"
    }
    else{
        return "";
    }
}

function middleThree(str)
{
    let len = Math.round(str.length / 2, 0);

    return str[len-2] + str[len-1] + str[len];
}

function frontAgain(str)
{
    let len = str.length - 1
    if(str[0] == str[len-1] && str[1] == str[len])
    {
        return true;
    }else{
        return false;
    }
}

let user = "Chris";

function greeting()
{
    alert("Hi " + user + "!");
}

function alarmClock(dayI, bool)
{
    var days = [];
    var day = {name:"sunday", alarmTime: "10:00"}
    days.push(day);
    var day = {name:"monday", alarmTime: "7:00"}
    days.push(day);
    var day = {name:"tuesday", alarmTime: "7:00"}
    days.push(day);
    var day = {name:"wednsday", alarmTime: "7:00"}
    days.push(day);
    var day = {name:"thursday", alarmTime: "7:00"}
    days.push(day);
    var day = {name:"friday", alarmTime: "7:00"}
    days.push(day);
    var day = {name:"saturday", alarmTime: "10:00"}
    days.push(day);

    if(bool)
    {
        days[dayI].alarmTime = "10:00";
    }

console.table(days);

console.log(days[dayI].name + " " + days[dayI].alarmTime);
}

function makeMiddle(arr)
{
    if(arr.length % 2 != 0 || arr.length < 2)
    {
        return [];
    }
    else{
        var mid = arr.length/2 -1;
        return [arr[mid], arr[mid+1]]; 
    }
}

function oddOnly(arr)
{
    function isOdd(num)
    {
        return num % 2 != 0;
    }

    const result = arr.filter(isOdd);

    return result;
}

function weave(arrA, arrB)
{
    var long, shrt, longlen, shrtlen;

    if(arrA.length >= arrB.length)
    {
        long = arrA; 
        shrt = arrB;
    }else{
        long = arrB; 
        shrt = arrA;
    }
    var longLen = long.length;
    var shrtLen = shrt.length;

    var result = [];

    var i = 0;
    while( i < longLen)
    {
        
            result.push(long.shift());
            
            if(i < shrtLen)
            {
            result.push(shrt.shift());
            }
            i++;      
    }
   
    return result;
}

function cigarParty(cigs, wkEnd)
{
    if(wkEnd && cigs >= 40)
    {
        return true;
    }
    else if(!wkEnd && cigs >= 40 && cigs <= 60)
    {
        return true;
    }
    else
    {
        return false;
    }
}

function stringSplosion(str)
{
    var result = "";
    console.log(result);
    for(var i = 0; i < str.length; i++) 
    {
        console.log("outer for");
        for(var y = 0; y <= i; y++)             
        {
            console.log("inner for");
            result += str[y];             
        }
    }

    return result;
}

function fizzBuzz()
{   
    for(var i = 1; i <= 100; i++)
    {
        var line = "";
        if(i % 3 == 0)
        {
            line += "Fizz";
        }
        if(i % 5 == 0)
        {
            line += "Buzz";
        }
        if(i % 3 !=0 && i % 5 != 0)
        {
            line = i;
        }
        console.log(line);
    }
}

function countValues(arr)
{
    var set = new Set();
    for(var i = 0; i < arr.length; i++)
    {
        var num = new Object();
           num.number = arr[i];
           num.count =  1;
        
        hasNum = false;
        for(var y = 0; y < set.length; y++)
        {
            if(set[y].number == num.number)
            {
                set[y].count++
                hasNum = true;
            }
        }
        if(!hasNum)
        {
            set.add(num);
        }
    }

return set;    
}

function reverseArray(arr)
{
    var reverse = [];

    while(arr.length > 0)
    {
        reverse += arr.splice(arr.length-1,1) + " ";
    }
   
    return reverse;
}

function blackjack(n1, n2)
{
    if(n1 == 21) // n1 is the dealer and wins if there is a draw
    {
        return n1;
    }
    if(n2 == 21)
    {
        return n2;
    }
    if(n1 <= 21 && n2 > 21)
    {
        return n1;
    }
    if(n1 > 21 && n2 <= 21)
    {
        return n2;
    }

    if(n1 > n2)
    {
        return n1;
    }
    else 
    {
        return n2;
    }
}