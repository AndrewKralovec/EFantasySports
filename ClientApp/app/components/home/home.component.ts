import { Component, OnInit, AfterViewInit } from '@angular/core';
import { LoginService } from './login.service'

@Component({
    selector: 'home',
    providers: [LoginService],
    templateUrl: './home.component.html'
})
export class HomeComponent implements AfterViewInit {
    constructor(private ls:LoginService){
    }
    ngAfterViewInit(){
        //$('ul.tabs').tabs();
    }
    // Login in user
    login(){
        this.ls.login('akrala@yahoo.com', 'Linux01!', false); 
    }
    registor(){
        this.ls.registor('akrala@yahoo.com', 'Linux01!', 'Linux01!'); 
    }
    test(){
        this.ls.test();
    }
}
