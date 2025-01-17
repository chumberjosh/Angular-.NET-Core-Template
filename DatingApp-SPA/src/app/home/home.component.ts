import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@Angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  loginMode = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {

  }

  registerToggle() {
    this.registerMode = true;
  }

  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

  loginToggle() {
    this.loginMode = true;
  }

  cancelLoginToggle(loginMode: boolean) {
    this.loginMode = loginMode;

}
}
