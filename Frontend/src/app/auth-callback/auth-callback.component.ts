import { Component, OnInit } from '@angular/core';
import {UserManager} from 'oidc-client'
import { UserManagerFactory } from '../shared/user-manager-factory.service';
import { DimensionsService } from '../dimensions/dimensions.service';
import { Dimension } from '../dimensions/model/dimensions';

@Component({
  selector: 'app-auth-callback',
  templateUrl: './auth-callback.component.html',
  styleUrls: ['./auth-callback.component.css']
})
export class AuthCallbackComponent implements OnInit {

  private dimensions : Array<Dimension>;
  private userManager: UserManager;
  constructor(private dimensionService:DimensionsService, factory:UserManagerFactory){
    this.userManager = factory.createUserManager();
  }

  ngOnInit() {
    this.userManager.signinRedirectCallback().then(user=>{
      debugger;
      this.dimensionService.getAll()
            .subscribe(data=> this.dimensions = data );
    });
  }

}
