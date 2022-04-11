import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginRegisterService } from '../../services/login-register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  person = {
    username: '',
    password: '',
    email: '',
  };
  emailExists = '';
  constructor(
    private loginRegister: LoginRegisterService,
    private router: Router
  ) {}

  ngOnInit(): void {}
  onSubmit(form: any) {
    this.loginRegister.registerUser(form.value).subscribe(
      (res: any) => {
        localStorage.setItem('email', res.email);
        this.router.navigate(['/']).then(() => {
          window.location.reload();
        });
        console.log(localStorage.getItem('email'));
      },
      (err) => {
        this.emailExists = 'User Already Exist. Please Login!';
      }
    );
    // console.log(form.value);
    // console.log(person);
  }
}
