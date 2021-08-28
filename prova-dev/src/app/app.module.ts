import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { cadastroComponent } from './cadastro/cadastro.component';
import { DadosPessoaisComponent } from './dados-pessoais/dados-pessoais.component';
import { FinalizarComponent } from './finalizar/finalizar.component';

@NgModule({
  declarations: [
    AppComponent,
    cadastroComponent,
    DadosPessoaisComponent,
    FinalizarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
