/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { StreamingComponent } from './streaming.component';

describe('StreamingComponent', () => {
  let component: StreamingComponent;
  let fixture: ComponentFixture<StreamingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StreamingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StreamingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
