import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import { Manager } from '../../../../models/manager';
import 'rxjs/add/operator/map'; 

@Injectable()
export class DashboardSettingsService {
    private headers = new Headers({ 'Content-Type': 'application/json' });
    constructor(private http:Http) {
    }
    getUserInfo() {
        return this.http.get('/api/Settings/GetUser')
        .map(response  => response.json())
    }
    updateManager(manager: Manager){
        console.log(manager); 
        this.http.post('/api/Settings/UpdateManager', manager ,{headers:this.headers})
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