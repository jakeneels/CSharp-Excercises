/// <reference path="../jquery-3.1.1.js" />


$(document).ready(function () {

  var rowNum = 0;
  var colNum = 0;

  console.log("doc ready hi");

  $('body').on('keydown', function(e) {
    //l37, u38, r39, d40
    //down
    if (e.keyCode == 40) {
      console.log("pressed d");
      if (IsValidPos(rowNum + 1, colNum)) {
        $(`#row_${rowNum}_column_${colNum}`).removeClass('ship');
        rowNum++;
        IsEndGame(rowNum, colNum);
        $(`#row_${rowNum}_column_${colNum}`).addClass('ship');
      }
    }

    //right
    if (e.keyCode == 39) {
      console.log("pressed r");
      if (IsValidPos(rowNum, colNum + 1)) {
        $(`#row_${rowNum}_column_${colNum}`).removeClass('ship');
        colNum++;
        IsEndGame(rowNum, colNum);
        $(`#row_${rowNum}_column_${colNum}`).addClass('ship');
      }
    }

    //up
    if (e.keyCode == 37) {
      console.log("pressed l");
      if (IsValidPos(rowNum, colNum - 1)) {
        $(`#row_${rowNum}_column_${colNum}`).removeClass('ship');
        colNum--;
        IsEndGame(rowNum, colNum);
        $(`#row_${rowNum}_column_${colNum}`).addClass('ship');
      }
    }

    // left
    if (e.keyCode == 38) {
      console.log("pressed u");
      if (IsValidPos(rowNum - 1, colNum)) {
        $(`#row_${rowNum}_column_${colNum}`).removeClass('ship');
        rowNum--;
        IsEndGame(rowNum, colNum);
        $(`#row_${rowNum}_column_${colNum}`).addClass('ship');
      }
    }
  });

  function IsEndGame(rowNum, colNum) {
    if ($(`#row_${rowNum}_column_${colNum}`).hasClass('iceberg') || $(`#row_${rowNum}_column_${colNum}`).hasClass('pirate')) {
      alert("You Lose!");

      location.reload();
      //reset game!
    }

    if ($(`#row_${rowNum}_column_${colNum}`).hasClass('treasure')) {
      alert("You Win !!!");

      location.reload();
    }
  }

  function IsValidPos(rowNum, colNum) {
    
    if (rowNum <= 9 && rowNum >= 0 && colNum <= 9 && colNum >= 0) {
      return true;
    } else {
      console.log("out of map bounds")
      return false;
    }
  }







  $("#SameShipping").click(function () {

    console.log("same ship click");

    if ($("#SameShipping").is(":checked")) {
      $("#ShippingAddress1").val($("#BillingAddress1").val());
      $("#ShippingAddress2").val($("#BillingAddress2").val());
      $("#ShippingCity").val($("#BillingCity").val());
      $("#ShippingState").val($("#BillingState").val());
      $("#ShippingPostalCode").val($("#BillingPostalCode").val());
    }
    else {
      $("#ShippingAddress1").val("");
      $("#ShippingAddress2").val("");
      $("#ShippingCity").val("");
      $("#ShippingState").val("");
      $("#ShippingPostalCode").val("");
    }

  });


  $("#shipping-info").click(function () {

    var shipPrices = [];

    $("#ShippingType[data-cost]").each(function () {

      shipPrices.push($(this).data('cost'))

    });

    if (shipPrices.length >= 4) {

      if ($("#ShippingType[value='Standard']").is(':checked')) {
        $("#shipping>.price").text(shipPrices[0]);

      }
      else if ($("#ShippingType[value='Express']").is(':checked')) {
        $("#shipping>.price").text(shipPrices[1]);

      }
      else if ($("#ShippingType[value='Two-Day']").is(':checked')) {
        $("#shipping>.price").text(shipPrices[2]);

      }
      else if ($("#ShippingType[value='Overnight']").is(':checked')) {
        $("#shipping>.price").text(shipPrices[3]);
      }
    }
  });
});




