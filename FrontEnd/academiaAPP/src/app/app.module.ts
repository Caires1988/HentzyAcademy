import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent } from './app.component';
import { NavbarComponent } from './components/layout/navbar/navbar.component';
import { CadastroAlunosComponent } from './components/pages/cadastro-alunos/cadastro-alunos.component';
import { ConsultaAlunosComponent } from './components/pages/consulta-alunos/consulta-alunos.component';
import { EdicaoAlunosComponent } from './components/pages/edicao-alunos/edicao-alunos.component';
import { AppRoutingModule } from './app.routing';
import { CadastroFuncionariosComponent } from './components/pages/cadastro-funcionarios/cadastro-funcionarios.component';
import { ConsultaFuncionariosComponent } from './components/pages/consulta-funcionarios/consulta-funcionarios.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    CadastroAlunosComponent,
    ConsultaAlunosComponent,
    EdicaoAlunosComponent,
    CadastroFuncionariosComponent,
    ConsultaFuncionariosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, //Adicionando as configurações das rotas
    FormsModule, //Para utilizar formulários
    ReactiveFormsModule //Para utilizar formulários reativos

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
