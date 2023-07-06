import { Component } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { SeoService } from '../../../services/seo/seo.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  name = environment.application.name;
  items = [
    {
      icon: "fa-brands fa-readme",
      name: "Books",
      description: "Search for books",
      link:'/books'
    },
  ]

  constructor(private seoService: SeoService) {
    const content = ' It applies Routing, Lazy loading and Progressive Web App (PWA)';
    const title = 'angular-starter Title : Home Page';

    this.seoService.setMetaDescription(content);
    this.seoService.setMetaTitle(title);
  }
}