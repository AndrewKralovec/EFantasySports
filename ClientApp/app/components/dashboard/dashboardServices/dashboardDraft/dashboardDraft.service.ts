import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 

const mock = [
         { playerID: 1, lastName : "Kralovec", firstName : "Andrew", postion:"QB" }, 
         { playerID: 2, lastName : "Kralovec", firstName : "Matt", postion:"QB" }, 
         { playerID: 3, lastName : "Smith", firstName : "John", postion:"TE" }, 
         { playerID: 4, lastName : "Miller", firstName : "Joe", postion:"TE" }, 
         { playerID: 5, lastName : "Hoster", firstName : "Blake", postion:"K" }, 
         { playerID: 6, lastName : "Gongo", firstName : "Frank", postion:"K" }, 
         { playerID: 7, lastName : "Tiroski", firstName : "Josh", postion:"DL" }, 
         { playerID: 8, lastName : "FarFar", firstName : "Mike", postion:"DL" }, 
         { playerID: 9, lastName : "Banker", firstName : "Kelly", postion:"DL" }, 
         { playerID: 10, lastName : "York", firstName : "Eric", postion:"DL" }, 
         { playerID: 11, lastName : "Wacker", firstName : "Freddy", postion:"DL" }, 
         { playerID: 12, lastName : "Bishop", firstName : "Mike", postion:"OL" }, 
         { playerID: 13, lastName : "Bennet", firstName : "Matt", postion:"OL" }, 
         { playerID: 14, lastName : "Kowolski", firstName : "Ben", postion:"OL" }, 
         { playerID: 15, lastName : "Russon", firstName : "George", postion:"OL" }, 
         { playerID: 16, lastName : "Viker", firstName : "Mike", postion:"OL" }
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
    /*
    getPlayers() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/Game/GetPlayers')
        .map(response  => response.json())
    }
    */ 
}