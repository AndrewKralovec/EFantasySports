import { Component, OnInit } from '@angular/core';
import { DashboardDraftService } from './dashboardDraft.service';

@Component({
    selector: 'dashboard-draft',
    providers:[DashboardDraftService],
    templateUrl: './dashboardDraft.component.html',
    styleUrls: ['./dashboardDraft.component.css']
})
export class DashboardDraftComponent implements OnInit {
    private players:Array<any> = Array(); 
    constructor(private dds:DashboardDraftService){
        
    }
    ngOnInit(){
        this.dds.getPlayers()
        .subscribe((response:any) => {
            console.log("Response:");
            console.log(response);
            this.players = response ; 
        }, (error:any) => {
            console.log("Error:");
            console.log(error);
        },() => 
            console.log("Request Finished")
        );
    }
}
