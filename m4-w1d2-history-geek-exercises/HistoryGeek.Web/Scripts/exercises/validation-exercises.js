/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {
  console.log("valid");

  $("#form0").validate({

    EmailAddress: {
      email: true,
      required: true
    },
    Password: {
      required: true,
      minlength: 8,
      strongPassword: true
    },
    ConfirmPassword: {
      required: true,
      equalTo: "#Password"
    }
  })

  $("#checkout").validate({
    
    rules: {

      NameOnCard: {
        required: true,
        
      },
      CreditCardNumber: {
        required: true,
        digits: true,
        minlength: 15,
        maxlength: 16
      },
      ExpirationDate: {
        minlength: 4,
        maxlength:5,
        required: true
      },
      messages: {
        NameOnCard: "Full name required",
        CreditCardNumber: {
          minlength: "Invalid number please enter again",
          maxlength: "Invalid number please enter again"
        },
        ExpirationDate: "mm/yy format ex. 01/18 for Jan 2018"
      },

      errorClass: "error", //css
      validClass: "valid"
    }
  });
   
});


