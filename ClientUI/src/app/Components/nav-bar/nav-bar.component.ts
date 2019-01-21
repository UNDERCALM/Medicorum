import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {
  canSearch: boolean;
  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.canSearch = false;
    console.log(this.router.url);
  }

}
