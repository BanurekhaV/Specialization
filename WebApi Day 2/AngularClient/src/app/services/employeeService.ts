import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {NgForm} from '@angular/forms';

@Injectable()
export class EmployeeService
{
 constructor(private http:HttpClient)
 {

 }
 getEmployee()
 {
     debugger;
     return this.http.get("http://localhost:52400/api/employees");
 }

 getTax(id:number)
 {
    // let empid=id.value;
     debugger;
   console.log(id);
     return this.http.get("http://localhost:52400/api/employees/"+id);
 }

 //get emp details for particular department

 
}
