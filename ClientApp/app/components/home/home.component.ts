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
}
