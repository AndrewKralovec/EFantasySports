import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http' 
import 'rxjs/add/operator/map'
//import 'rxjs/Rx';
//import { History } from '../models/history';
//import { User } from '../models/user';


@Injectable()
export class LoginService {
    constructor(private router:Router, private http:Http){
    }
    // Find user in database, if exists, and log them in  
    login(email:any, password:any, remember:any) {
        //let body:User = {email:email, password:password}; 
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let body = {Email:email, Password:password,RememberMe:false }; 
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
    registor(email:any, password:any, confirm:any){
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let body = {Email:email, Password:password,ConfirmPassword:confirm }; 
        console.log(body); 
        this.http.post('/api/Account/Register', body ,{headers:headers})
        .map(response  => response.json())
        .subscribe(
             response => { 
                 console.log("Success !!!:\n"); 
                 console.log(response); 
                 this.router.navigate(['/home']);
            }, 
            error => {
                 console.log("Error !!!:\n"); 
                 console.log(error); 
            }
        );
    }
    test(){
        this.http.get('/api/Team/getTeam')
        .map(response  => response.json())
        .subscribe(
             response => { 
                 console.log("Success !!!:\n"); 
                 console.log(response); 
            }, 
            error => {
                 console.log("Error !!!:\n"); 
                 console.log(error); 
            }
        );
    }
}