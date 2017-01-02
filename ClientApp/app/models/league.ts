import { Team } from './team';
export interface League {
    leagueID:number; 
    leagueLogo?:string; 
    leagueName?:string; 
    teams?:Array<Team>; 
}