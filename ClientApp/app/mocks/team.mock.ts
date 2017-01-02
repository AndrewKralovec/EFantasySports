import { Team } from '../models/team';
export const MockTeam:Team = { 
    teamID: 1, 
    teamName:"Lions", 
    teamLogo:"Team-Logo.jpeg", 
    managerID: 1,
    leagueID: 1, 
    league: {
        leagueID:1,
        leagueName:""

    }, 
    manager: {
        managerID:1, 
        managerName:"Andrew Kralovec"
    }, 
    players: [
        { playerID: 1, lastName : "Kralovec", firstName : "Andrew", postion:"Top" }, 
        { playerID: 2, lastName : "Kralovec", firstName : "Matt", postion:"Top" }, 
        { playerID: 3, lastName : "Smith", firstName : "John", postion:"Jungler" }, 
        { playerID: 4, lastName : "Miller", firstName : "Joe", postion:"Jungler" }
    ]
}