import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BottomFrameComponent } from './bottom-frame.component';

describe('BottomFrameComponent', () => {
  let component: BottomFrameComponent;
  let fixture: ComponentFixture<BottomFrameComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BottomFrameComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BottomFrameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
