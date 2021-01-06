import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-team',
  templateUrl: './create-team.component.html',
  styleUrls: ['./create-team.component.css']
})
export class CreateTeamComponent implements OnInit {

  teamForm: FormGroup
  constructor(private fb:FormBuilder) {
    this.teamForm = this.fb.group({
      'teamName': ['',[Validators.required]]
    })
   }

  ngOnInit(): void {
  }

  create(){
    console.log(this.teamForm.value)
  }
}
