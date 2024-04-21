import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {
  private roleData = new BehaviorSubject<any>(null);
  roleData$ = this.roleData.asObservable();

  constructor() { }

  setRoleData(data: any) {
    this.roleData.next(data);
  }
}
