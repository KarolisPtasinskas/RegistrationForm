import { Component, OnInit } from '@angular/core';
import { FormsService } from '../../services/forms.service';
import { RegistrationForm } from 'src/app/models/registrationForm';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css'],
})
export class FormsComponent implements OnInit {
  forms: RegistrationForm[] = [];

  constructor(private formsService: FormsService) {}

  ngOnInit(): void {
    this.formsService.getForms().subscribe((forms) => (this.forms = forms));
  }
}
