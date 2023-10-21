import { Component, OnInit } from '@angular/core';
import { Aluno } from 'src/app/shared/model/aluno-model';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css']
})
export class ConsultaAlunosComponent implements OnInit {

  alunos: Aluno[] = []
  quantidadeDeAlunos: number = 0

  constructor(){}

  ngOnInit(): void {
    this.alunos = [

      {
        nome: 'Cláudia Soares',
        idade: 23,
        observacoes:'Aluno apto à se exercitar'
      },



      {
        nome: 'Joaquin Silva',
        idade: 55,
        observacoes:'Aluno inapto à se exercitar'
      },


      {
        nome: 'Rita Ribeiro',
        idade: 18,
        observacoes:'Aluno apto à se exercitar'
      },
    ];

    this.quantidadeDeAlunos = this.alunos.length;



  }


}
