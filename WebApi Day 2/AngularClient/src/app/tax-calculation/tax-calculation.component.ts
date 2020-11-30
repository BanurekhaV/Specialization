import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/EmployeeService';
import { NgForm} from '@angular/forms'; 

@Component({
  selector: 'app-tax-calculation',
  templateUrl: './tax-calculation.component.html',
  styleUrls: ['./tax-calculation.component.css']
})
export class TaxCalculationComponent implements OnInit {

  constructor(private empservice:EmployeeService) { }

  ngOnInit(): void {
  }

  Taxamount;
  t;
  calculateTax(id:number)
  {
    console.log(id);
 
    debugger;
    this.empservice.getTax(id).subscribe((data)=>{this.Taxamount=data;console.log(data)});
    console.log(this.Taxamount);
    //this.t=this.Taxamount;
   // console.log(this.t);

  }

}
