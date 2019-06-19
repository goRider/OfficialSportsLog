import { Component, OnInit } from '@angular/core';
import { HttpClient } from 'selenium-webdriver/http';

@Component({
  selector: 'app-admin-users',
  templateUrl: './admin-users.component.html',
  styleUrls: ['./admin-users.component.css']
})
export class AdminUsersComponent implements OnInit {
  public admins: AdminUsers[];

  constructor() {
  }

  ngOnInit() {
    
  }

}

interface AdminUsers {
  userId : number;
  firstName : string;
  middleName : string;
  lastName : string;
  created : Date;
  email : string;
}
