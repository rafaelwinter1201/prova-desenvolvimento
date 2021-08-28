import { ComponentFixture, TestBed } from '@angular/core/testing';

import { cadastroComponent } from './cadastro.component';

describe('CadastroComponent', () => {
  let component: cadastroComponent;
  let fixture: ComponentFixture<cadastroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ cadastroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(cadastroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
