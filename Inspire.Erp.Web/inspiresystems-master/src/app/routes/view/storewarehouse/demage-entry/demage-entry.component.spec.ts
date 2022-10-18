import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DemageEntryComponent } from './demage-entry.component';

describe('DemageEntryComponent', () => {
  let component: DemageEntryComponent;
  let fixture: ComponentFixture<DemageEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DemageEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DemageEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
