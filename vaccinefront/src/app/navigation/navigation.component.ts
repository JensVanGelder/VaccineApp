import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountService } from '../services/account.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {

  title = 'Vaxx.id';

  constructor(private activeRoute: ActivatedRoute, private accountService: AccountService, private userService: UserService, private router: Router) { }

  ngOnInit(): void {
  }

  logout(): void {
    localStorage.removeItem('user');
    window.location.href = '/';
  }

}
