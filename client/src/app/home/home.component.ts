import { Component, inject, OnInit } from '@angular/core';
import { RegisterComponent } from "../register/register.component";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit { 
  http = inject(HttpClient);
  registerMode = false;
  users: any;

  ngOnInit(): void {
    this.getUsers();
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  getUsers(): void {
    this.http.get('https://localhost:5001/api/users').subscribe(
      response => {
        this.users = response;
      },
      error => {
        console.log(error);
      },
      () => {
        console.log('complete');
      }
    );
  }

  cancelRegister($event: boolean) {
    this.registerMode = $event;
  }
}
