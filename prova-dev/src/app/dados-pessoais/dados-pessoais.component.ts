
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Cadastro } from '../models/cadastro';

@Component({
  selector: 'app-dados-pessoais',
  templateUrl: './dados-pessoais.component.html',
  styleUrls: ['./dados-pessoais.component.scss']
})
export class DadosPessoaisComponent implements OnInit {
  public cadastroForm!: FormGroup;

  public cadastros = [
    {dtnasc: 'rafael', celular:'rafael@gmail', profissao:'32563258966'},
    {dtnasc: 'douglas', celular:'douglas@gmail', profissao:'32587412369'},
    {dtnasc: 'eduardo', celular:'eduardo@gmail', profissao:'12365896512'},
  ];

  enviocadastro(){
    alert('this.cadastroForm.value');
  }

  constructor(private fb: FormBuilder){
    this.criaForm();
  }

  criaForm(){
    this.cadastroForm = this.fb.group({
      dtnasc: [''],
      celular: [''],
      profissao: [''],
      renda: [''],
    })
  }

  ngOnInit(): void {

  }

}
