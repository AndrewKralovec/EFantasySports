// Directives
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule, ReactiveFormsModule }   from '@angular/forms';
import { MaterializeDirective } from 'angular2-materialize';
// Pipes 
import { ImageSrc } from './pipes/imageSrc.pipe';
// Page components 
import { AppComponent } from './components/app/app.component'
import { HeaderComponent } from './components/header/header.component'
import { FooterComponent } from './components/footer/footer.component'
// Dashboard components 
import { DashboardComponent } from './components/dashboard/dashboard.component'
import { DashboardNavMenuComponent } from './components/dashboard/dashboardServices/dashboardNavmenu/dashboardNavmenu.component';
import { DashboardHomeComponent } from './components/dashboard/dashboardServices/dashboardHome/dashboardHome.component';
import { DashboardDraftComponent } from './components/dashboard/dashboardServices/dashboardDraft/dashboardDraft.component';
import { DashboardTeamComponent } from './components/dashboard/dashboardServices/dashboardTeam/dashboardTeam.component';
import { DashboardLeagueComponent } from './components/dashboard/dashboardServices/dashboardLeague/dashboardLeague.component';
import { DashboardSettingsComponent } from './components/dashboard/dashboardServices/dashboardSettings/dashboardSettings.component';
// Main components
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { LoaderComponent } from './components/loader/loader.component';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        // Directives
        MaterializeDirective,
        // Components
        AppComponent,
        HomeComponent, 
        HeaderComponent, 
        FooterComponent,
        LoaderComponent, 
        LoginComponent,
        RegisterComponent, 
        DashboardComponent, 
        DashboardNavMenuComponent,
        DashboardHomeComponent, 
        DashboardDraftComponent,
        DashboardTeamComponent,
        DashboardLeagueComponent,
        DashboardSettingsComponent,
        // Pipes 
        ImageSrc
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        FormsModule, 
        ReactiveFormsModule, 
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'login', component: LoginComponent },
            { path: 'register', component: RegisterComponent },
            { path: 'dashboard', component: DashboardComponent, children: [
                { path: '', component: DashboardHomeComponent },
                { path: 'draft', component: DashboardDraftComponent },
                { path: 'league', component: DashboardLeagueComponent },
                { path: 'team', component: DashboardTeamComponent },
                { path: 'settings', component: DashboardSettingsComponent },
                { path: '**', redirectTo: '', pathMatch: 'full' }
            ]},
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
