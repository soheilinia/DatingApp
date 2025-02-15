import { Component, inject, OnInit } from '@angular/core';
import { NavComponent } from "./nav/nav.component";
import { AccountService } from './_services/account.service';
import { RouterOutlet } from '@angular/router';
import { NgxSpinnerComponent } from "ngx-spinner";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [NavComponent, RouterOutlet, NgxSpinnerComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {  
  private accountService = inject(AccountService);
  
  ngOnInit(): void {
    this.setCurrentUser();
  }

  setCurrentUser() {
    const userStrig = localStorage.getItem('user');
    if (!userStrig) { return; }
    const user = JSON.parse(userStrig);
    this.accountService.currentUser.set(user);
  }

}
