import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http' 
import { User } from '../../models/user';
import 'rxjs/add/operator/map'

@Injectable()
export class RegisterService {
    constructor(private router:Router, private http:Http){
    }
    register(user:User){
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let body = { Email:user.email, Password:user.password, ConfirmPassword:user.confirmPassword }; 
        console.log(body); 
        this.http.post('/api/Account/Register', body ,{headers:headers})
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