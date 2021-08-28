import { FormGroup, FormBuilder } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Cadastro } from '../models/cadastro';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})

export class cadastroComponent implements OnInit {

  public cadastroForm!: FormGroup;
  public enviodado!: Cadastro;
  public cadastra!: Cadastro;


  public cadastros = [
    {nome: 'rafael', email:'rafael@gmail', cpf:'32563258966', renda:'200$'},
    {nome: 'douglas', email:'douglas@gmail', cpf:'32587412369', renda:'300$'},
    {nome: 'eduardo', email:'eduardo@gmail', cpf:'12365896512', renda:'400$'},
  ];

  enviocadastro(cadastra: Cadastro){
    console.log(this.cadastroForm);
  }

  constructor(private fb: FormBuilder){
    this.criaForm();
  }

  criaForm(){
    this.cadastroForm = this.fb.group({
      nome: [''],
      email: [''],
      cpf: [''],
      renda: [''],
    })
  }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

}

