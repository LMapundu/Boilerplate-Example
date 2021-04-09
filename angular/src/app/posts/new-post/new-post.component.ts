import { AppComponentBase } from 'shared/app-component-base';
import { Component, Injector, OnInit } from '@angular/core';
import { CategoryDTO, CategoryServiceProxy, CreatePostDto, PostServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-new-post',
  templateUrl: './new-post.component.html',
  styleUrls: ['./new-post.component.css'],
  providers: [CategoryServiceProxy]
})
export class NewPostComponent extends AppComponentBase implements OnInit {

  postInput: CreatePostDto = new CreatePostDto()
  categories: CategoryDTO[] = []

  constructor(injector: Injector, public bsModalRef: BsModalRef,
    private postService: PostServiceProxy,
    private categoryService: CategoryServiceProxy) {
    super(injector)
  }

  ngOnInit() {
    this.getAllCategories();
  }
  save() {
    this.postService.create(this.postInput)
      .subscribe(res => {
        this.notify.success('Post Created Successfully')
      }, error => {
        this.notify.error('An Error Occurred')
      })
  }

  getAllCategories() {
    this.postInput.authorId = 1;
    this.categoryService.getAll()
      .subscribe(result => {
        this.categories = result
        console.log(result)
      })
  }

}
