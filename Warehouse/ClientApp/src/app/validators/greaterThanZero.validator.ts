import { AbstractControl } from "@angular/forms";

export function GreaterThanZero(control: AbstractControl): { [key: string]: boolean } | null {
  return control.value > 0 ? null : { greaterThanZero: true };
}
