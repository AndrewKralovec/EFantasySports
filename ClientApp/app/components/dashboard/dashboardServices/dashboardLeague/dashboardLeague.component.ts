import { Component, OnInit } from '@angular/core';
import { DashboardLeagueService } from './dashboardLeague.service';
import { League } from '../../../../models/league';
import 'rxjs/add/operator/map'; 

@Component({
    selector: 'dashboard-League',
    providers:[DashboardLeagueService],
    templateUrl: './dashboardLeague.component.html',
    styleUrls: ['./dashboardLeague.component.css']
})
export class DashboardLeagueComponent implements OnInit{
    private league:League = null; 
    constructor(private dl:DashboardLeagueService){

    }
    ngOnInit(){
        this.dl.getLeagueInfo()
        .subscribe((response:any) => {
            console.log("Response:");
            this.league = response ; 
            console.log(this.league);
        }, (error:any) => {
            console.log("Error:");
            console.log(error);
        },() => 
            console.log("Request Finished")
        );
    }
}
