import{Component} from '@angular/core';
import { ApiService } from './api.service';

@Component ({
    templateUrl:  './question.component.html',
    selector:'question'

})

export class QuestionComponent {
    question = {
        text:'O`zbekistonni poytaxti qayer?',
        correctAnswer:'Tashkent',
        wrongAnswers:['Samarqand','Farg`ona','Qashqadaryo']
    }
    constructor( private apiSvc: ApiService){

    }
    post(){
        this.apiSvc.postQuestion(this.question);
    }
}