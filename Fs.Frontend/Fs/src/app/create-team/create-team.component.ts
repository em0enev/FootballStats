import { HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TeamService } from '../services/team.service';

@Component({
  selector: 'app-create-team',
  templateUrl: './create-team.component.html',
  styleUrls: ['./create-team.component.css']
})
export class CreateTeamComponent implements OnInit {

  teamForm: FormGroup
  constructor(private fb: FormBuilder, private teamService: TeamService) {
    this.teamForm = this.fb.group({
      'teamName': ['', [Validators.required]],
      'leagueName': ['']
    })
  }

  ngOnInit(): void {
  }

  create() {
    console.log(this.teamForm.value)
    this.teamService
      .create(this.teamForm.value)
      .subscribe(res => console.log(res))
  }

  get teamName() {
    return this.teamForm.get('teamName')
  }
}
