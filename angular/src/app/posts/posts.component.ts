import { PostDto, PostServiceProxy } from './../../shared/service-proxies/service-proxies';
import { Component, OnInit } from '@angular/core';
import { BsModalService } from 'ngx-bootstrap/modal';
import { NewPostComponent } from './new-post/new-post.component';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css'],
  providers: [PostServiceProxy]
})
export class PostsComponent implements OnInit {

  posts: PostDto[] = []
  constructor(private postService: PostServiceProxy,
    private _modalService: BsModalService) { }

  ngOnInit(): void {
    this.getAllPosts()
  }

  getAllPosts() {
    this.postService.getAll()
      .subscribe(result => {
        console.log(result)
        this.posts = result;
      })
  }
  createPost() {
    this._modalService.show(
      NewPostComponent,
      {
        class: 'modal-lg',
      }
    );
  }
}
