import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultaFornecedoresComponent } from './consulta-fornecedores.component';

describe('ConsultaFornecedoresComponent', () => {
  let component: ConsultaFornecedoresComponent;
  let fixture: ComponentFixture<ConsultaFornecedoresComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ConsultaFornecedoresComponent]
    });
    fixture = TestBed.createComponent(ConsultaFornecedoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
