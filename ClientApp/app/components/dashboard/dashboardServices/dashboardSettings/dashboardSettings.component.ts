import { Component, EventEmitter, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { DashboardSettingsService } from './dashboardSettings.service';
import { Manager } from '../../../../models/manager';

@Component({
    selector: 'dashboard-settings',
    providers:[DashboardSettingsService],
    templateUrl: './dashboardSettings.component.html',
    styleUrls: ['./dashboardSettings.component.css']
})
export class DashboardSettingsComponent implements OnInit {
    private manager:Manager = null; 
    private editable:boolean = false; 
    private managerForm: FormGroup;
    constructor(private fb: FormBuilder, private ds:DashboardSettingsService){

    }
    ngOnInit(){
        // Set form
        this.managerForm = new FormGroup({
            managerName: new FormControl('',[Validators.required])
        });
        // Get info
        this.ds.getUserInfo()
        .subscribe((response:any) => {
            console.log("Response:");
            console.log(response); 
            this.manager = response.manager; 
        }, (error:any) => {
            console.log("Error:");
            console.log(error);
        },() => 
            console.log("Request Finished")
        );
    }
    edit():void {
        this.editable = !this.editable
    }
    updateManager(manager: Manager, isValid: boolean) {
        if(isValid){
            this.ds.updateManager(manager); 
            this.editable = false; 
        }
    }
}
