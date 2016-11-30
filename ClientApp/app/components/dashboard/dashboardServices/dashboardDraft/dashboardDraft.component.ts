import { Component, EventEmitter, OnInit, AfterViewInit } from '@angular/core';
import { DashboardDraftService } from './dashboardDraft.service';
import 'rxjs/add/operator/map'; 
import { Player } from '../../../../models/player';
@Component({
    selector: 'dashboard-draft',
    providers:[DashboardDraftService],
    templateUrl: './dashboardDraft.component.html',
    styleUrls: ['./dashboardDraft.component.css']
})
export class DashboardDraftComponent implements OnInit {
    private players:Array<Player> = Array(); 
    private draftedPlayer:Array<Player> = Array(); 
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
