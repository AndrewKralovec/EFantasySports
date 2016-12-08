import { Component } from '@angular/core';
import { RegistorService } from './registor.service';

@Component({
    selector: 'login',
    providers: [RegistorService],
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class RegistorComponent {
    constructor(private rs:RegistorService){
    }
    // Registor in user
    registor(email: any, password: any){
        this.rs.registor(email, password, false); 
    }
}
