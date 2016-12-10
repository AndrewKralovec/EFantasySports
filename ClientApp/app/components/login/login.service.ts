import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http' 
import { User } from '../../models/user';
import 'rxjs/add/operator/map'

@Injectable()
export class LoginService {
    constructor(private router:Router, private http:Http){
    }
    // Remove user from storage
    logout() {
        if(this.isLoggedIn) {
            localStorage.removeItem("user");
            this.router.navigate(['/login']);
        }
    }
    // Add user to storage
    storeUser(user){
        localStorage.setItem("user", JSON.stringify(user));
        this.router.navigate(['/home']);      
    }
    // Check if user is logged in
    isLoggedIn() {
        if(localStorage.getItem("user") == null || localStorage.getItem("user") == undefined )
            return false;
        return true;  
    }
    // Find user in database, if exists, and log them in  
    login(user: User) {
        //let body:User = {email:email, password:password}; 
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let body = { Email:user.email, Password:user.password, RememberMe:user.rememberMe }; 
        console.log(body); 
        this.http.post('/api/Account/Login', body ,{headers:headers})
        .map(response  => response.json())
        .subscribe(
             response => { 
                 console.log("Success !!!:\n"); 
                 console.log(response); 
                 if(response.succeeded) {
                     this.router.navigate(['/dashboard']);   
                 }
            }, 
            error => {
                 console.log("Error !!!:\n"); 
                 console.log(error); 
            }
        );
    }
    // Alert user of error 
    userError(error) {
        console.log(error); 
        alert("The user could not be found, please try again"); 
    }
}