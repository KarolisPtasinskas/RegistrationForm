import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { RegistrationForm } from 'src/app/models/registrationForm';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css'],
})
export class FormComponent implements OnInit {
  @Input() form: RegistrationForm;
  @Output() onEditForm: EventEmitter<number> = new EventEmitter();

  constructor() {}

  ngOnInit(): void {}
}
