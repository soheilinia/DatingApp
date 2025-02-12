import { Component, inject, OnInit } from '@angular/core';
import { RegisterComponent } from "../register/register.component";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {  
  registerMode = false;
  
  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegister($event: boolean) {
    this.registerMode = $event;
  }
}