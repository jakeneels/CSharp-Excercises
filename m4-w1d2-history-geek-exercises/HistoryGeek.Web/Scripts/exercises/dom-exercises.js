/// <reference path="../jquery-3.1.1.js"/>
//Locate all <div> elements and add the 'president' class.


function presentialDivs() {
  $("#presidents>div").addClass("president");
  console.warn("presDivs");
}

//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
  $("#george-washington").addClass("founding-father");
}

//Locate all Republican presidents and add the 'red' class.
function republicanPresidents() {
  $(".Republican").addClass("red");
}

//Locate all Democrat presidents and add the 'blue' class.
function democratPresidents() {
  $(".Democratic").addClass("blue");
}

//Locate all Federalist presidents and add the 'gold' class.
function otherPresidents() {
  $(".Federalist").addClass("gold");
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
  var h3 = $("#presidents>div h3");

  h3.each(function () {
    var name = this.innerHTML.toString();
    if (name[0] == "j" && name[1] == "a" && name[2] == "m" && name[3] == "e" && name[4] == "s") {
      $(this).addClass("james");
    }
    })

  console.warn("pres h3? " + name + " <=")

  //$("#presidents>div").addClass("James");

}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {

}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    
  

}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {
  $(".currency").addClass("appearOnCurrency");

}

$(function () {

  $("#btnPresident").click(function () {
    console.warn("clicked");
    presentialDivs();

  });

  $("#btnPresident").click();

  $("#btnFoundingFather").click(function () {
    console.warn("clicked");
    georgeWashington();

  });

  $("#btnRepublicans").click(function () {
    console.warn("clicked");
    democratPresidents();

  });

  $("#btnDemocrats").click(function () {
    console.warn("clicked");
    republicanPresidents();

  });

  $("#btnOther").click(function () {
    console.warn("clicked");
    otherPresidents();

  });

  $("#btnJames").click(function () {
    console.warn("clicked");
    presidentsNamedJames();

  });

  $("#btnBeginningOfCentury").click(function () {
    console.warn("clicked");
    presentialDivs();

  });

  $("#btnEndOfCentury").click(function () {
    console.warn("clicked");
    presentialDivs();

  });

  $("#btnAppearOnCurrency").click(function () {
    console.warn("clicked");
    presentialDivs();

  });

})