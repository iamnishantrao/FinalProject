import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
import { SignupService } from '../../services/signup.service';
import { SignupModel } from '../../models/signup.model';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  @Input() signupFlag: boolean;
  @Output() signupflagValueChanged = new EventEmitter<boolean>();
  signupModel: SignupModel;
  Firstname: string;
  Username: string;
  email: string;
  confirmpassword: string;
  password: string;
  Lastname: string;
  result;
  constructor(private signupService: SignupService) {
  }

  ngOnInit() {
  }
  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);

  matcher = new MyErrorStateMatcher();

  signup() {

    if ((this.Firstname == '') || (this.Username == '') || (this.email == '')) {
      alert("Field is Required");
    }
    if (this.confirmpassword == this.password) {
      this.signupModel = {
        password: this.password,
        userName: this.Username,
        firstName: this.Firstname,
        lastName: this.Lastname,
        email: this.email
      };

      this.signupService.doSignup(this.signupModel).subscribe(data => {
        this.result = data;
        this.signupFlag = !this.signupFlag;
        this.signupflagValueChanged.emit(this.signupFlag);
      });

    }
    else {
      alert("Confirm Password Not Matched");
    }
  }
  goBack() {
    this.signupFlag = !this.signupFlag;
    this.signupflagValueChanged.emit(this.signupFlag);
  }

}
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

