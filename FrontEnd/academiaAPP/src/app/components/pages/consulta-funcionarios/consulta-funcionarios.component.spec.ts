import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultaFuncionariosComponent } from './consulta-funcionarios.component';

describe('ConsultaFuncionariosComponent', () => {
  let component: ConsultaFuncionariosComponent;
  let fixture: ComponentFixture<ConsultaFuncionariosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ConsultaFuncionariosComponent]
    });
    fixture = TestBed.createComponent(ConsultaFuncionariosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
