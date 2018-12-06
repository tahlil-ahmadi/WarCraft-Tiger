import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthCallbackComponent } from './auth-callback/auth-callback.component';
import { UserManagerFactory } from './shared/user-manager-factory.service';
import { DimensionsService } from './dimensions/dimensions.service';

@NgModule({
  declarations: [
    AppComponent,
    AuthCallbackComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    UserManagerFactory, 
    DimensionsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
