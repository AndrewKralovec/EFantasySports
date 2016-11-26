using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding; 

namespace EFantasySports.Models.Utility
{
    public class AccountResponse : Response {
        public AccountResponse(bool succeeded, string message)
            :base(succeeded) {
                this.succeeded = succeeded ;
                this.messages.Add(message); 
        }
        public AccountResponse(bool succeeded, List<IdentityError> errors)
            :base(succeeded) {
                this.succeeded = succeeded; 
                foreach(var error in errors){
                    this.messages.Add(error.Description.ToString());
                }
        }
        public AccountResponse(bool succeeded, ModelStateDictionary state)
            :base(succeeded) {
                this.succeeded = succeeded; 
                var errors = state.Values;
                foreach (var error in errors) {
                    foreach(var e in error.Errors) {
                        this.messages.Add(e.ErrorMessage); 
                    }
                }
        }
    }
}