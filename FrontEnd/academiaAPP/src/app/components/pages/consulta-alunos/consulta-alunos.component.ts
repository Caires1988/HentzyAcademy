import { Component, OnInit } from '@angular/core';
import { AlunosServiceService } from 'src/app/services/alunos.service.service';
import { Aluno } from 'src/app/shared/model/aluno-model';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css']
})
export class ConsultaAlunosComponent implements OnInit {

  alunos: Aluno[] = []
  quantidadeDeAlunos: number = 0

  constructor(private alunosService: AlunosServiceService){}

  ngOnInit(): void {
    this.alunosService.getAllAlunos().subscribe(data => {
      this.alunos = data
    })

    this.quantidadeDeAlunos = this.alunos.length;



  }


}
