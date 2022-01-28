import { Component} from '@angular/core';

import { TempLogin } from '../TempLogin';
import { TempNewCustomer } from '../TempCustomer';
import { MyhttpService } from '../myhttp.service';

@Component({
  selector: 'app-login-screen',
  templateUrl: './login-screen.component.html',
  styleUrls: ['./login-screen.component.css']
})
export class LoginScreenComponent{
  showHome:boolean = true;
  showNew:boolean = false;
  showReturn:boolean = false;
  
  User: TempLogin[] = [];
  customer: TempNewCustomer[] = [];

  constructor(
    private service: MyhttpService
  ) 
  {
    
  }

  ngOnInit(): void {
  }

  ReturnedCus()
  {
    this.showHome = false;
    this.showReturn = true;
  }

  NewCus()
  {
      this.showHome = false;
      this.showNew = true;
  }

  Back()
  {
    this.showHome = true;
    this.showNew = false;
    this.showReturn = false;
  }

  onSubmitCustomer(fname:string, lname:string, username:string, password:string): void{

  }

  onSubmitUser(username:string, password:string) {
    this.User = [{
      Username: username,
      Password: password
    }]

    this.service.getUserInfo(this.User[0].Username)
      .then((getCustomer) => { this.customer = getCustomer; });
      
      // alert(this.customer[0].FirstName + "\n" + this.customer[0].LastName+ "\n" + 
      //       this.customer[0].Username + "\n" + this.customer[0].Password);
  }
}
