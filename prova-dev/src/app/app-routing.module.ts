import { FinalizarComponent } from './finalizar/finalizar.component';
import { cadastroComponent } from './cadastro/cadastro.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DadosPessoaisComponent } from './dados-pessoais/dados-pessoais.component';

const routes: Routes = [
  { path: 'cadastro', component: cadastroComponent },
  { path: 'dadospessoais', component: DadosPessoaisComponent},
  { path: 'finalizar', component: FinalizarComponent},
  { path: '', redirectTo: 'cadastro', pathMatch:'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
