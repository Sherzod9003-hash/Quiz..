import{Component} from '@angular/core';
import { ApiService } from '../api.service';
import { ResourceLoader } from '@angular/compiler';

@Component ({
    templateUrl:  './questions.component.html',
    selector:'questions'

})

export class QuestionsComponent {
  questions;
   
    constructor( private apiSvc: ApiService){
   
}
ngOnInit(){
  this.apiSvc.getQuestions().subscribe( result=>{
   this.questions=result;
  })
}
}