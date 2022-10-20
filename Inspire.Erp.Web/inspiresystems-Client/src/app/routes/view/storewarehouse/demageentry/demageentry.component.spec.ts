import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DemageentryComponent } from './demageentry.component';

describe('DemageentryComponent', () => {
  let component: DemageentryComponent;
  let fixture: ComponentFixture<DemageentryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DemageentryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DemageentryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
