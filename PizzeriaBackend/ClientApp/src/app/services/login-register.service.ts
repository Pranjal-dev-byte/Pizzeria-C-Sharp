import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class LoginRegisterService {
  _url = 'https://localhost:44366/api/';
  constructor(private http: HttpClient) {}

  registerUser(person: any) {
    console.log(person);
    return this.http.post(this._url + 'Authenticate/register', {
      email: person.email,
      username: person.name,
      password: person.password,
    });
  }
  loginUser(person: any) {
    return this.http.post(this._url + 'Authenticate/login', {
      email: person.email,
      password: person.password,
    });
  }
}
