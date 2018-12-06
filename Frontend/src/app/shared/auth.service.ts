import { User } from "oidc-client";
import { Injectable } from "@angular/core";

@Injectable()
export class AuthService {

    private currentUser:User;

    setCurrentUser(user:User){
        this.currentUser = user;
    }

    getAccessToken():string{
        return `${this.currentUser.token_type} ${this.currentUser.access_token}`;
    }
}