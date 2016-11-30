import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule }   from '@angular/forms';
import { MaterializeDirective } from 'angular2-materialize';

import { AppComponent } from './components/app/app.component'
import { HeaderComponent } from './components/header/header.component'
import { FooterComponent } from './components/footer/footer.component'

import { DashboardComponent } from './components/dashboard/dashboard.component'
import { DashboardNavMenuComponent } from './components/dashboard/dashboardServices/dashboardNavmenu/dashboardNavmenu.component';
import { DashboardHomeComponent } from './components/dashboard/dashboardServices/dashboardHome/dashboardHome.component';
import { DashboardDraftComponent } from './components/dashboard/dashboardServices/dashboardDraft/dashboardDraft.component';
import { DashboardTeamComponent } from './components/dashboard/dashboardServices/dashboardTeam/dashboardTeam.component';


import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        MaterializeDirective,
        AppComponent,
        HeaderComponent, 
        FooterComponent, 
        DashboardComponent, 
        DashboardNavMenuComponent,
        DashboardHomeComponent, 
        DashboardDraftComponent,
        DashboardTeamComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule, 
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'dashboard', component: DashboardComponent, children: [
                { path: '', component: DashboardHomeComponent },
                { path: 'draft', component: DashboardDraftComponent },
                { path: '**', redirectTo: '', pathMatch: 'full' }
            ]},
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
