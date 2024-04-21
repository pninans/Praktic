import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrl: './logout.component.css'
})
export class LogoutComponent {

  constructor(private router: Router) { 
   
    setTimeout(() => {
      this.router.navigate(['/']); 
    }, 2000);
  }
}

