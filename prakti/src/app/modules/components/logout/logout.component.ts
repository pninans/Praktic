import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrl: './logout.component.css'
})
export class LogoutComponent {

  constructor(private router: Router) { 
    // הפעלת setTimeout לאחר 2 שניות והניווט לדף הבית
    setTimeout(() => {
      this.router.navigate(['/']); // מעבר לדף הבית
    }, 2000); // זמן המתנה במילישניות
  }
}

