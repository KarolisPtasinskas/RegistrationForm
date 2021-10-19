import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FormsService } from 'src/app/services/forms.service';
import { FormOption } from 'src/app/models/formOption';
import { OptionValue } from 'src/app/models/optionValue';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-edit-form',
  templateUrl: './edit-form.component.html',
  styleUrls: ['./edit-form.component.css'],
})
export class EditFormComponent implements OnInit {
  id: string;
  formOptions: FormOption[] = [];

  selectDisabled: boolean = true;
  buttonText: string = 'Edit';

  constructor(
    private activatedRoute: ActivatedRoute,
    private formsService: FormsService
  ) {}

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(
      (param) => (this.id = param.get('id'))
    );

    this.formsService.getOptions(this.id).subscribe((optionsFromDb) => {
      this.formOptions = optionsFromDb;
      console.log(this.formOptions);
    });
  }

  onChange(value: string, optionId: number) {
    let index = this.formOptions.findIndex((o) => o.id == optionId);

    let updatedOption = {
      id: this.formOptions[index].id,
      name: this.formOptions[index].name,
      regFormId: parseInt(this.id),
      selectedValueId: parseInt(value),
      values: this.formOptions[index].values,
    };

    this.updateOptions(updatedOption);
  }

  updateOptions(updatedOption) {
    this.formsService.putOptions(updatedOption).subscribe();
  }

  toggleSelectDisabled() {
    this.selectDisabled = !this.selectDisabled;
    this.buttonText === 'Edit'
      ? (this.buttonText = 'Hide')
      : (this.buttonText = 'Edit');
  }
}
