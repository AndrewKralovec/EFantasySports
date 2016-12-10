import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { LoginService } from './login.service';
import { User } from '../../models/user';

@Component({
    selector: 'login',
    providers: [LoginService],
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    private loginForm: FormGroup; // our model driven form
    private submitted: boolean; // keep track on whether form is submitted
    private events: any[] = []; // use later to display form changes

    constructor(private fb: FormBuilder, private ls:LoginService){
    }
    ngOnInit(){
        this.loginForm = new FormGroup({
            email: new FormControl('',[Validators.required]),
            password: new FormControl('', [Validators.required,Validators.minLength(6)]),
            rememberMe: new FormControl(false)
        });
    }
    login(user: User, isValid: boolean) {
        if(isValid){
            this.ls.login(user);
        }
    }
}
