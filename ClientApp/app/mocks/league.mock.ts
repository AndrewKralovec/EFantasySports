import { League } from '../models/league';
export const MockLeague:League = {
    leagueID:1, 
    leagueName:"Kralovec League",
    leagueLogo:"League-Logo.png",
    teams:[ 
        {
            teamID:1, 
            teamName:"Lions"
        }, 
        {
            teamID:2, 
            teamName:"Tigers"
        }, 
        {
            teamID:3, 
            teamName:"Kralovec Team"
        }

    ]
}