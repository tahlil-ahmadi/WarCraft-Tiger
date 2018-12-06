import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Dimension } from './model/dimensions';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class DimensionsService {

    constructor(private http:HttpClient){}

    getAll(): Observable<Array<Dimension>>{
      return this.http.get<Array<Dimension>>("http://localhost:29211/api/MeasurementDimensions");
    }
}
