import { Component, OnInit } from '@angular/core';
import { DashboardDraftService } from './dashboardDraft.service';

@Component({
    selector: 'dashboard-draft',
    templateUrl: './dashboardDraft.component.html',
    styleUrls: ['./dashboardDraft.component.css']
})
export class DashboardDraftComponent implements OnInit {
    private players:Array<any> = Array(); 
    constructor(private dds:DashboardDraftService){
        
    }
    ngOnInit(){
        this.players = this.dds.getPlayers(); 
    }
}
