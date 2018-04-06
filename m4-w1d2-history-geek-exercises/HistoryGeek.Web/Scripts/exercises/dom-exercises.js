/// <reference path="../jquery-3.1.1.js"/>
//Locate all <div> elements and add the 'president' class.
<<<<<<< HEAD


function presentialDivs() {
  $("#presidents>div").addClass("president");
  console.warn("presDivs");
=======
function presentialDivs() {
    $("#presidents div").addClass("president");
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
<<<<<<< HEAD
  $("#george-washington").addClass("founding-father");
=======
    $("#george-washington").addClass("founding-father");
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
<<<<<<< HEAD
  $(".Republican").addClass("red");
=======
    $(".Republican").addClass("red");
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
<<<<<<< HEAD
  $(".Democratic").addClass("blue");
=======
    $(".Democratic").addClass("blue");
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate all Federalist presidents and add the '
//gold' class.
function otherPresidents() {
<<<<<<< HEAD
  $("#presidents>div").remove(".Democratic").remove(".Republican").addClass("gold");;

=======
    $(".president").not(".Democratic").not(".Republican").addClass("gold");
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
<<<<<<< HEAD

  $("div[id^='james']").addClass('James');

  //$("#presidents>div").addClass("James");

=======
    $(".president[id^='james']").addClass('james');
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate each president serving at the beginning of 
//each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
<<<<<<< HEAD
  $("#presidents h2").after().addClass("beginningOfCentury");
=======
    $("h2+div").addClass("beginningOfCentury");
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate each president serving at the end of the 
//century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
<<<<<<< HEAD
  $("#presidents h2").before().addClass("endOfCentury");
=======
    $("h2").prev().addClass("endOfCentury");
    $(".president").last().addClass("endOfCentury");
    
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107
}

//Locate all presidents serving in the 1900s who appear
//on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
<<<<<<< HEAD
  $("#presidents h2").after(1990).addClass("appearOnCurrency");
}
=======

    var items = $(".currency");

    items.each(function (item) {
        //console.log("item: ", $(item).find("p"))
        if ($(item).find("p")[0].text().startsWith("(19")) {
            $(item).addClass("appearOnCurrency");
            console.log("adding");
        }
    })
>>>>>>> 4bbf193f78fd99495f74320f64f741b7b2695107


