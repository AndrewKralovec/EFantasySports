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
        this.loginForm = this.fb.group({
            email: ['', [<any>Validators.required]],
            password: ['', [<any>Validators.required, <any>Validators.minLength(6)]],
            rememberMe: ['']
        });
    }
    save(model: User, isValid: boolean) {
        this.submitted = true;
        console.log(model, isValid);
    }
    // Login in user
    login(email: any, password: any){
        this.ls.login(email, password, false); 
    }
}
