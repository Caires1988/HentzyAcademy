import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Aluno } from '../shared/model/aluno-model';
@Injectable({
  providedIn: 'root'
})
export class AlunosServiceService {

  constructor(private httpClient: HttpClient) { }

  getAllAlunos( ){
    return this.httpClient.get<Aluno[]>('http://localhost:13185/Aluno/GetAllAluno')

  }

  createAluno(aluno: Aluno){
    return this.httpClient.post<any>('http://localhost:13185/Aluno/CreateAluno', aluno)
  }
}
