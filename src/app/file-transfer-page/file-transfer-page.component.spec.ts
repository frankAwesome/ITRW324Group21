import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FileTransferPageComponent } from './file-transfer-page.component';

describe('FileTransferPageComponent', () => {
  let component: FileTransferPageComponent;
  let fixture: ComponentFixture<FileTransferPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FileTransferPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FileTransferPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
