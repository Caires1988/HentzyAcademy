import { CadastroFuncionariosComponent } from './components/pages/cadastro-funcionarios/cadastro-funcionarios.component';
import { RouterModule, Routes } from "@angular/router";
import { CadastroAlunosComponent } from "./components/pages/cadastro-alunos/cadastro-alunos.component";
import { ConsultaAlunosComponent } from "./components/pages/consulta-alunos/consulta-alunos.component";
import { EdicaoAlunosComponent } from "./components/pages/edicao-alunos/edicao-alunos.component";

import { NgModule } from "@angular/core";
import { ConsultaFuncionariosComponent } from './components/pages/consulta-funcionarios/consulta-funcionarios.component';
import { CadastroFornecedoresComponent } from './components/pages/cadastro-fornecedores/cadastro-fornecedores.component';
import { ConsultaFornecedoresComponent } from './components/pages/consulta-fornecedores/consulta-fornecedores.component';


// mapeamento das rotas do projeto
const routes: Routes = [
{ path: 'pages/cadastro-alunos', component: CadastroAlunosComponent },
{ path: 'pages/consulta-alunos', component: ConsultaAlunosComponent },
{ path: 'pages/edicao-alunos', component: EdicaoAlunosComponent },
{path: 'pages/cadastro-funcionarios', component: CadastroFuncionariosComponent},
{path: 'pages/consultar-funcionarios', component: ConsultaFuncionariosComponent},
{path: 'pages/cadastro-fornecedores', component: CadastroFornecedoresComponent},
{path: 'pages/consultar-fornecedores', component: ConsultaFornecedoresComponent},
{ path: '', pathMatch: 'full', redirectTo:'pages/consulta-alunos' }

];


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})


export class AppRoutingModule {}
