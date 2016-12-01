import { Component, EventEmitter, OnInit, AfterViewInit } from '@angular/core';
import { DashboardDraftService } from './dashboardDraft.service';
import 'rxjs/add/operator/map'; 
import { Player } from '../../../../models/player';
import {MaterializeAction} from 'angular2-materialize';

@Component({
    selector: 'dashboard-draft',
    providers:[DashboardDraftService],
    templateUrl: './dashboardDraft.component.html',
    styleUrls: ['./dashboardDraft.component.css']
})
export class DashboardDraftComponent implements OnInit {
    private players:Array<Player> = Array(); 
    private draftedPlayers:Array<Player> = Array(); 
    modalActions = new EventEmitter<string|MaterializeAction>();
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
    onPick(player:Player, index:number){
        this.draftedPlayers.push(player); 
    }
}
