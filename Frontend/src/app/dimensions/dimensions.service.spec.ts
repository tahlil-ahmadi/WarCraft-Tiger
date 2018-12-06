import { TestBed } from '@angular/core/testing';

import { DimensionsService } from './dimensions.service';

describe('DimensionsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DimensionsService = TestBed.get(DimensionsService);
    expect(service).toBeTruthy();
  });
});
