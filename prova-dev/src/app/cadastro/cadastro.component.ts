
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';




@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})

export class cadastroComponent {

    nome!: string;
    email!: string;

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.log('this.profileForm.value');
  }
}


