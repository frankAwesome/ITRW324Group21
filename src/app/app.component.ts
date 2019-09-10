import {Component, OnInit} from '@angular/core';
import { HttpClient} from "@angular/common/http";
import {User} from "./user.model";
import {DataService} from "./data.service";
import {RouterModule, Routes} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'office-tools-web';
  users$: User[];

  constructor(private dataService: DataService) {}



}
