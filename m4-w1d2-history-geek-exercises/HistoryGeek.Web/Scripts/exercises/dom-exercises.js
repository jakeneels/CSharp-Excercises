/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
function presentialDivs() {
    $("#presidents div").addClass("president");
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
    $(".president").not(".Democratic").not(".Republican").addClass("gold");
}

//Locate all presidents named 'James' and add the 'james' class.
function presidentsNamedJames() {
    $(".president[id^='james']").addClass('james');
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
function turnOfTheCenturyPresidents() {
    $("h2+div").addClass("beginningOfCentury");
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
function endOfTheCenturyPresidents() {
    $("h2").prev().addClass("endOfCentury");
    $(".president").last().addClass("endOfCentury");
    
}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
function currencyPresidents() {

    var items = $(".currency");

    items.each(function (item) {
        //console.log("item: ", $(item).find("p"))
        if ($(item).find("p")[0].text().startsWith("(19")) {
            $(item).addClass("appearOnCurrency");
            console.log("adding");
        }
    })


}