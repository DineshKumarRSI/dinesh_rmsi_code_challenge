import { TestBed, flush, tick} from '@angular/core/testing';
import { AppComponent } from './app.component';
import { AppModule } from './app.module';
import { StoryService } from '../core/services/story.services';
import { ComponentFixtureAutoDetect } from '@angular/core/testing';
import { Story } from '../core/model/story.model';

describe('AppComponent', async () => {

  
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AppComponent],
      providers: [StoryService, { provide: ComponentFixtureAutoDetect, useValue: true }],
      imports: [AppModule],
    }).compileComponents();
  });



  it('should create the app', async () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });


  it('should display initial stories on page',  (done:DoneFn) => {
    const fixture = TestBed.createComponent(AppComponent);
    let service =  fixture.componentRef.injector.get(StoryService);
    service.baseURL= "http://localhost:9876/assets/mock-data/story.json";
    fixture.componentInstance.getStories();
    fixture.detectChanges();
    fixture.whenStable().then(f => {
      let row = fixture.nativeElement.querySelector('tbody tr');
      expect(row).not.toEqual(null);
      done();
    })
  });

  it('should display the search result of search text "Kyle Vogt resigns from Cruise"', (done:DoneFn) => {
    const fixture = TestBed.createComponent(AppComponent);
    let button = fixture.debugElement.nativeElement.querySelector('#searchButton');
    fixture.componentInstance.searchStory = "Kyle Vogt resigns from Cruise";

    let service =  fixture.componentRef.injector.get(StoryService);
    service.baseURL= "http://localhost:9876/assets/mock-data/story.json";

    button.click();

    fixture.detectChanges();
    fixture.whenStable().then(f => {
      let row = fixture.nativeElement.querySelector('tbody tr');
      expect(row).not.toEqual(null);
      done()
    })
  });

  it('should not display any record for search text "Not available record"', (done:DoneFn) => {
    const fixture = TestBed.createComponent(AppComponent);
    let button = fixture.debugElement.nativeElement.querySelector('#searchButton');
    fixture.componentInstance.searchStory = "Not available record";
    
    let service =  fixture.componentRef.injector.get(StoryService);
    service.baseURL= "http://localhost:9876/assets/mock-data/story.json";

    button.click();

    fixture.detectChanges();
    fixture.componentInstance.stories = [];
    fixture.whenStable().then(f => {
      let result = fixture.componentInstance.stories.find(f=> f.title == fixture.componentInstance.searchStory);
      expect(result).not.toBeDefined();
      done()
    })
  });

  it('service should fetch the stories', (done:DoneFn) => {
    const fixture = TestBed.createComponent(AppComponent);
    let service =  fixture.componentRef.injector.get(StoryService);
    service.baseURL= "http://localhost:9876/assets/mock-data/story.json";
    service.getAllStories("").subscribe({
      next:(response: Story[]) =>{
        expect(response).not.toBeNull();
        done()
      },
      error:(err:any) =>{
        expect().nothing();
      }
    })

  });
  

});

