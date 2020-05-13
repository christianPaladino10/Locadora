import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Streaming } from '../_models/Streaming';

@Injectable({
  providedIn: 'root'
})
export class StreamingService
{
  baseURL = 'http://localhost:5000/api/streaming';

  constructor(private http: HttpClient) { }

  getAllStreaming(): Observable<Streaming[]>
  {
    return this.http.get<Streaming[]>(this.baseURL);
  }
}
