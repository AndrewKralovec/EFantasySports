import { Player } from './player';
import { Manager } from './manager';
import { League } from './league';
export interface Team {
    teamID:number;
    teamName: string;
    teamLogo?:string; 
    managerID?: number;
    leagueID?: number;
    league?: League;
    manager?: Manager;
    players?: Array<Player>; 
    lineUp?:any;
}