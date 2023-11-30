import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Story } from '../model/story.model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/internal/operators/map';

@Injectable({
  providedIn: 'root',
})
export class StoryService {

  baseURL: string = "http://localhost:5275/api/story"
  constructor(private httpClient: HttpClient) { }

  /**
   * Name: getAllStories
   * @param searchStory : Search text  
   * @returns : Observable story array 
   */
  getAllStories(searchStory:string | null) {
    let url = this.baseURL ;
    if(searchStory!= null && searchStory != "" ){
      url += "?searchStory=" + searchStory
    }
    return this.httpClient.get<Story[]>(url);
  }
}