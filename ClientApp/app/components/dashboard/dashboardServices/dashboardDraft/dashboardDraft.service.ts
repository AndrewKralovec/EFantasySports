import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 

// Mock notification
const mock:any[] = [
    {
        id:0,
        name:"Antonio Brown", 
        postion:"Postion", 
        message:"Final (W) 28-7 @ Ind", 
        avgPick:1.2, 
        avgRound:1.1, 
        drafted:1
    },
    {
        id:1,
        name:"David Johnson", 
        postion:"Postion", 
        message:"Sun 10:00 am @ Cle",
        avgPick:2.4, 
        avgRound:1.1, 
        drafted:1
    },
    {
        id:2,
        name:"Julio Jones", 
        postion:"Postion", 
        message:"Sun 10:00 am @ Atl",
        avgPick:4.5, 
        avgRound:1.4, 
        drafted:1
    },
    {
        id:3,
        name:"Todd Gurley", 
        postion:"Postion", 
        message:"Sun 10:00 am @ Ari",
        avgPick:8.3, 
        avgRound:1.5, 
        drafted:1
    },
    {
        id:4,
        name:"Rob Gronkowski", 
        postion:"Postion", 
        message:"Sun 1:25 pm @ NYJ",
        avgPick:9.7, 
        avgRound:1.6, 
        drafted:1
    }
]; 

@Injectable()
export class DashboardDraftService {
    constructor(private http:Http) {
    }
    getPlayers() {
        return Observable.create((observer: any) => {
            setTimeout(() => {
                observer.next(mock);
                observer.complete();
            }, 500);
        });
    }
}