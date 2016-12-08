import { Component } from '@angular/core';
import { LoginService } from './login.service';

@Component({
    selector: 'login',
    providers: [LoginService],
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent {
    constructor(private ls:LoginService){
    }
    // Login in user
    login(email: any, password: any){
        this.ls.login(email, password, false); 
    }
}
