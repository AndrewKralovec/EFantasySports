import { Component, EventEmitter, OnInit, AfterViewInit } from '@angular/core';
import { DashboardDraftService } from './dashboardDraft.service';
import {MaterializeAction} from 'angular2-materialize';
import 'rxjs/add/operator/map'; 
import { Player } from '../../../../models/player';
import { Team } from '../../../../models/team';

@Component({
    selector: 'dashboard-draft',
    providers:[DashboardDraftService],
    templateUrl: './dashboardDraft.component.html',
    styleUrls: ['./dashboardDraft.component.css']
})
export class DashboardDraftComponent implements OnInit {
    private players:Array<Player> = null;
    private teams:Array<Team> = null  
    private draftedPlayers:Array<Player> = Array(); 
    modalActions = new EventEmitter<string|MaterializeAction>();
    constructor(private dds:DashboardDraftService){
    }
    ngOnInit(){
        this.dds.getTeams()
        .subscribe((response:any) => {
            console.log("Teams Response:");
            console.log(response);
            this.teams = response ; 
        }, (error:any) => {
            console.log("Error:");
            console.log(error);
        },() => 
            console.log("Request Finished")
        );
        this.dds.getPlayers()
        .subscribe((response:any) => {
            console.log("Players Response:");
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
