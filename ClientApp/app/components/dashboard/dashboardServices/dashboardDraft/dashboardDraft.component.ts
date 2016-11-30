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
    private draftedPlayer:Array<Player> = Array(); 
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
    ngAfterViewInit(){
    }
    openModal() {
        console.log('Read');
        this.modalActions.emit({action:"modal",params:['open']});
    }
    closeModal() {
        console.log('Close');
        this.modalActions.emit({action:"modal",params:['close']});
    }
    onPick(player:Player, index:number){
        for(let p of this.draftedPlayer){
            if(p == player){
                return ; 
            }
        }
        this.players[index].drafted = true ; 
        this.draftedPlayer.push(player); 
        console.log("Drafted Players"); 
        console.log(this.draftedPlayer); 
    }
}
