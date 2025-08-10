import { Component, inject, OnInit, ViewEncapsulation } from '@angular/core';
import { NavComponent } from "./nav/nav.component";
import { AccountService } from './_services/account.service';
import { RouterOutlet } from '@angular/router';
import { NgxSpinnerComponent } from "ngx-spinner";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [NavComponent, RouterOutlet, NgxSpinnerComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  encapsulation: ViewEncapsulation.Emulated
})
export class AppComponent implements OnInit {
  private accountService = inject(AccountService);

  ngOnInit(): void {
    this.setCurrentUser();
  }

  setCurrentUser() {
    const userString = localStorage.getItem('user');
    if (!userString) { return; }
    const user = JSON.parse(userString);
    this.accountService.setCurrentUser(user);
  }

}
