import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Dimension } from './model/dimensions';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { AuthService } from '../shared/auth.service';
import { debug } from 'util';

@Injectable({
  providedIn: 'root'
})
export class DimensionsService {

    constructor(private http:HttpClient){}

    getAll(): Observable<Array<Dimension>>{
      return this.http.get<Array<Dimension>>("http://localhost:29211/api/MeasurementDimensions");
    }

}
