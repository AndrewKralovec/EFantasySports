import { Team } from '../models/team';
export const MockTeam:Team = { 
    teamID: 1, 
    teamName:"Lions", 
    teamLogo:"Lions-Team-Logo.gif", 
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
    lineUp:[
        { playerID: 1, lastName : "Kralovec", firstName : "Andrew", postion:"Top" }, 
        { playerID: 3, lastName : "Smith", firstName : "John", postion:"Jungler" }, 
        { playerID: 6, lastName : "Gongo", firstName : "Frank", postion:"Flex player" }, 
        { playerID: 8, lastName : "FarFar", firstName : "Mike", postion:"Mid" }, 
        { playerID: 10, lastName : "York", firstName : "Eric", postion:"AD Carry" }, 
        { playerID: 13, lastName : "Bennet", firstName : "Matt", postion:"Support" }, 
        { playerID: 15, lastName : "Russon", firstName : "George", postion:"Team" }, 
    ], 
    players: [
        { playerID: 1, lastName : "Kralovec", firstName : "Andrew", postion:"Top" }, 
        { playerID: 3, lastName : "Smith", firstName : "John", postion:"Jungler" }, 
        { playerID: 6, lastName : "Gongo", firstName : "Frank", postion:"Flex player" }, 
        { playerID: 8, lastName : "FarFar", firstName : "Mike", postion:"Mid" }, 
        { playerID: 9, lastName : "Banker", firstName : "Kelly", postion:"Mid" }, 
        { playerID: 10, lastName : "York", firstName : "Eric", postion:"AD Carry" }, 
        { playerID: 11, lastName : "Wacker", firstName : "Freddy", postion:"AD Carry" }, 
        { playerID: 13, lastName : "Bennet", firstName : "Matt", postion:"Support" }, 
        { playerID: 14, lastName : "Kowolski", firstName : "Ben", postion:"Support" }, 
        { playerID: 15, lastName : "Russon", firstName : "George", postion:"Team" }, 
        { playerID: 16, lastName : "Viker", firstName : "Mike", postion:"Team" }
    ]
}