import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { MemberListsComponent } from './member-lists/member-lists.component';
import { HomeComponent } from './home/home.component';
import { Routes } from '@angular/router';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent},
    { path: 'members', component: MemberListsComponent},
    { path: 'messages', component: MessagesComponent},
    { path: 'lists', component: ListsComponent},
    { path: '**', redirectTo: 'home', pathMatch: 'full'},
];
