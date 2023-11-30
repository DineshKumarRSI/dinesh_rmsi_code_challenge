import { Component } from '@angular/core';
import { StoryService } from '../core/services/story.services';
import { Story } from '../core/model/story.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Story';
  stories: Story[] = [];
  loading: boolean = true;
  searchStory: string | null = null;

  constructor(private storyService: StoryService) {
  }

  /**
   * Name : ngOnInit
   * Purpose: Fetch story as page open on browser. 
   */
  ngOnInit() {
    this.getStories();
  }

  /** 
    * Name : searchStories
    * Purpose: Fetch the story as per the search value   
   */
  searchStories() {
    this.loading = true;
    this.getStories();
  }

  /**
    * Name: getStories
    * Purpose: Fetch the top stories and bind with property 
   */
  getStories() {
    this.stories = [];
    this.storyService.getAllStories(this.searchStory).subscribe({
      next: (response: Story[]) => {
        this.stories = response;
      },
      error: err => {
        this.loading = false;
      },
      complete: () => {
        this.loading = false;
      }
    })
  }

}
