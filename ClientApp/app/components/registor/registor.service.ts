import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http' 
import 'rxjs/add/operator/map'

@Injectable()
export class RegistorService {
    constructor(private router:Router, private http:Http){
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
}