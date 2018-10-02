import { Component, OnInit } from '@angular/core';
import { ProfileModel } from '../../models/profile.model';
import { ProfileService } from '../../services/profile.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profilepage.component.html',
  styleUrls: ['./profilepage.component.css']
})
export class ProfilepageComponent implements OnInit {

  profile: ProfileModel = {
    login: '',
    id: '',
    avatar_url: '',
    html_url: '',
    name: '',
    company: '',
    email: '',
    bio: '',
  }

  constructor(private profileService: ProfileService) { }

  ngOnInit() {
    this.profileService.getProfile().subscribe(data => this.profile = data);
    console.log(this.profile);
  }
}
