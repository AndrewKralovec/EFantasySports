import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { RegisterService } from './register.service';
import { User } from '../../models/user';

@Component({
    selector: 'register',
    providers: [RegisterService],
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
    private registerForm: FormGroup; // our model driven forms

    constructor(private rs:RegisterService){
    }
    ngOnInit(){
        this.registerForm = new FormGroup({
            email: new FormControl('',[Validators.required]),
            password: new FormControl('', [Validators.required,Validators.minLength(6)]),
            confirmPassword: new FormControl()
        });
    }
    // register in user
    register(user:User){
        this.rs.register(user); 
    }
}
