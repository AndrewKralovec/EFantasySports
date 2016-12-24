import { Component, EventEmitter, OnInit } from '@angular/core';
import { DashboardSettingsService } from './dashboardTeam.service';
import { Manager } from '../../../../models/manager';

@Component({
    selector: 'dashboard-settings',
    providers:[DashboardSettingsService],
    templateUrl: './dashboardSettings.component.html',
    styleUrls: ['./dashboardSettings.component.css']
})
export class DashboardSettingsComponent implements OnInit {
    private manager:Manager = null; 
    constructor(private ds:DashboardSettingsService){

    }
    ngOnInit(){
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
}
