import { TestBed } from '@angular/core/testing';

import { MedicorumAPIService } from './medicorum-api.service';

describe('MedicorumAPIService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MedicorumAPIService = TestBed.get(MedicorumAPIService);
    expect(service).toBeTruthy();
  });
});
