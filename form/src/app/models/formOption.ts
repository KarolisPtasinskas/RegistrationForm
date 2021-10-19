import { OptionValue } from '../models/optionValue';

export interface FormOption {
  id: number;
  name: string;
  regFormId: number;
  selectedValueId: number;
  values: OptionValue[];
}
