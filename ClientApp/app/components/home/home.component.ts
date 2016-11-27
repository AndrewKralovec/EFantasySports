import { Component, OnInit } from '@angular/core';
import { LoginService } from './login.service'
declare var $: any ;

@Component({
    selector: 'home',
    providers: [LoginService],
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
    constructor(private ls:LoginService){
    }
    ngOnInit(){
        /*
        $("p").click(function(){
            alert("The paragraph was clicked.");
        }); */  
    }
    // Login in user
    login(){
        this.ls.login('akrala@yahoo.com', 'Linux01!', false); 
    }
    registor(){
        this.ls.registor('akrala@yahoo.com', 'Linux01!', 'Linux01!'); 
    }
}
