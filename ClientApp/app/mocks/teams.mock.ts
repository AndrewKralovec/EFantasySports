import { Team } from '../models/team';
export const MockTeams:Array<Team> = [
    {
        teamID:1, 
        teamName:"Lions", 
        teamLogo:"Lions-Team-Logo.gif", 
        manager: {
            managerID:1, 
            managerName:"Andrew Kralovec"
        }
    }, 
    {
        teamID:2, 
        teamName:"Chicago-Gangsters", 
        teamLogo:"Chicago-Gangster-Team-Logo.png", 
        manager: {
            managerID:2, 
            managerName:"Matt Kralovec"
        }
    }, 
    {
        teamID:3, 
        teamName:"Kralovec Team", 
        teamLogo:"Team-Logo.jpeg", 
        manager: {
            managerID:3, 
            managerName:"John Smith"
        }
    }
] ; 