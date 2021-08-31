import { NgModule } from '@angular/core';
import { FormsModule, FormGroup, FormControl } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DadosPessoaisComponent } from './dados-pessoais/dados-pessoais.component';
import { FinalizarComponent } from './finalizar/finalizar.component';

@NgModule({
  declarations: [
    AppComponent,
    DadosPessoaisComponent,
    FinalizarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    FormGroup,
    FormControl
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
