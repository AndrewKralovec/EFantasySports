import { Component, EventEmitter, OnInit } from '@angular/core';
import { DashboardTeamService } from './dashboardTeam.service';
import { Team } from '../../../../models/team';
import 'rxjs/add/operator/map'; 

@Component({
    selector: 'dashboard-team',
    providers:[DashboardTeamService],
    templateUrl: './dashboardTeam.component.html',
    styleUrls: ['./dashboardTeam.component.css']
})
export class DashboardTeamComponent implements OnInit {
    private team:Team = null; 
    constructor(private dt:DashboardTeamService){

    }
    ngOnInit(){
        this.dt.getTeamInfo()
        .subscribe((response:any) => {
            console.log("Response:");
            console.log(response);
            this.team = response ; 
        }, (error:any) => {
            console.log("Error:");
            console.log(error);
        },() => 
            console.log("Request Finished")
        );
    }
}
