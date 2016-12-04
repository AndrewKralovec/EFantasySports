export interface Team {
    teamID:number;
    teamName: string;
    managerID: number;
    leagueID: number;
    league: Object;
    manager: Object;
    players: Array<any>; 
}