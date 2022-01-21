import { Component} from '@angular/core'; 

@Component({
  selector: 'app-login-screen',
  templateUrl: './login-screen.component.html',
  styleUrls: ['./login-screen.component.css']
})
export class LoginScreenComponent{
  showHome:boolean = true;
  showNew:boolean = false;
  showReturn:boolean = false;
  
  constructor() 
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
}
