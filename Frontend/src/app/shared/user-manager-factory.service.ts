import { Injectable } from "@angular/core";
import { UserManager } from "oidc-client";

@Injectable()
export class UserManagerFactory {

    createUserManager() : UserManager{
        var settings = {
            authority: 'http://localhost:5000/',
            client_id: 'warcraft-webui',
            redirect_uri: 'http://localhost:4200/auth-callback',
            response_type: "id_token token",
            scope: "openid profile uom productMng",
          };
        var manager = new UserManager(settings);
        return manager;
    }
}