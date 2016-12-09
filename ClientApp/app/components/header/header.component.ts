import { Component } from '@angular/core';
import { LoginService } from '../login/login.service'

@Component({
    selector: 'header-component',
    providers: [LoginService],
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent {
    constructor(private ls:LoginService){
    }
}