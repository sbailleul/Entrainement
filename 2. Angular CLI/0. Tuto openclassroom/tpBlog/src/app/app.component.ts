import { Component } from '@angular/core';
import {Post} from './post/post.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  posts = [
    new Post('Mon premier post' , 'text1', 3),
    new Post('Mon deuxième post' , 'text2', 4),
    new Post('Mon troisième post' , 'text3', 5)
  ];

  title = 'tpBlog';
}
