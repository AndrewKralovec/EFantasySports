import { Component } from '@angular/core';
import {LoginService} from './login.service'

@Component({
    selector: 'home',
    providers: [LoginService],
    templateUrl: './home.component.html'
})
export class HomeComponent {
    constructor(private ls:LoginService){
    }
    // Login in user
    login(){
        this.ls.login('email', 'password', false); 
    }
    registor(){
        this.ls.registor('akrala@yahoo.com', 'Linux01!', 'Linux01!'); 
    }
}
