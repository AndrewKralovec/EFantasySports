import { Team } from './team';
export interface Manager {
    id:number; 
    managerName:string; 
    teamID?:number; 
    team?:Team; 
}