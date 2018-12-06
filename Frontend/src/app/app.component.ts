import { Component } from '@angular/core';
import { UserManager, UserManagerSettings } from 'oidc-client'
import { UserManagerFactory } from './shared/user-manager-factory.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  private userManager: UserManager;
  constructor(factory:UserManagerFactory){
    this.userManager = factory.createUserManager();
  }

  login() {
    this.userManager.signinRedirect();
  }

}
