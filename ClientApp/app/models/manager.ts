import { Team } from './team';
export interface Manager {
    managerID:number; 
    managerName:string; 
    teamID?:number; 
    team?:Team; 
}