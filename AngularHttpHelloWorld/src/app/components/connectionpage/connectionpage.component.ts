import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-connectionpage',
  templateUrl: './connectionpage.component.html',
  styleUrls: ['./connectionpage.component.css']
})
export class ConnectionpageComponent implements OnInit {

  public retPostData;
  public retGetData;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  public PostData() {
    const url ="http://localhost:49528/api/Home";
    const retVal = this.http.post(url, {FstVarValue: '111', SndVarValue: '222'}).subscribe
    (data => {this.retPostData = data;
    });  
  }

  public GetData() {
    const url ="http://localhost:49528/api/Home/5";
    this.http.get(url).subscribe(data => {this.retGetData = data;});
  }

  public PutData() {
    const url="http://localhost:49528/api/Home/10";
    this.http.put(url, {DataVar1:'val1', DataVar2:'val2'})
    .subscribe(data => console.log(data));
  }

  public DeleteData() {
    const url ="http://localhost:49528/api/Home/5";
    this.http.delete(url).subscribe(data=> console.log(data),err=>{console.log("Error Occured")});
  }
}
