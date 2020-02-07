import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss']
})
export class PostComponent implements OnInit {

  @Input() post: Post;
  constructor() { }

  ngOnInit() {
  }

}

export class Post {

  title: string;
  content: string;
  loveIts: number;
  createdAt: Date;

  constructor(title, content, loveIts) {
    this.createdAt = new Date();
    this.title = title;
    this.content = content;
    this.loveIts = loveIts;
  }

  setLoveIts = (inc) => (this.loveIts += inc);
}
