import { Injectable } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

    constructor(private authService:AuthService) {
    }

  intercept(req: HttpRequest<any>, next: HttpHandler):Observable<HttpEvent<any>> {
    debugger;
    var token = this.authService.getAccessToken();

    const authReq = req.clone({
        headers: req.headers.set('Authorization', token)
    });

    return next.handle(authReq);
  }
}