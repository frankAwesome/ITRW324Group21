import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VoiceNotePageComponent } from './voice-note-page.component';

describe('VoiceNotePageComponent', () => {
  let component: VoiceNotePageComponent;
  let fixture: ComponentFixture<VoiceNotePageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VoiceNotePageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VoiceNotePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
