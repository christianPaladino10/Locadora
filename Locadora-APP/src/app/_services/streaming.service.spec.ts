/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { StreamingService } from './streaming.service';

describe('Service: Streaming', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StreamingService]
    });
  });

  it('should ...', inject([StreamingService], (service: StreamingService) => {
    expect(service).toBeTruthy();
  }));
});
