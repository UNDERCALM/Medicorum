import { TestBed } from '@angular/core/testing';

import { MedicorumConstantsService } from './medicorum-constants.service';

describe('MedicorumConstantsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MedicorumConstantsService = TestBed.get(MedicorumConstantsService);
    expect(service).toBeTruthy();
  });
});
