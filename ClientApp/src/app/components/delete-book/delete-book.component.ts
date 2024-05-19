import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BookService } from 'src/app/services/book.service';
import { AppState } from 'src/app/store/app.state';
import { Store } from '@ngrx/store';
import * as bookActions from './../../store/book.actions';

@Component({
  selector: 'app-delete-book',
  templateUrl: './delete-book.component.html',
  styleUrls: ['./delete-book.component.css']
})
export class DeleteBookComponent implements OnInit {

  book: any;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private store: Store<AppState>,
    private service: BookService) { }

  ngOnInit() {
    this.service.getBookById(this.route.snapshot.params.id).subscribe(data => {
      this.book = data;
    })
  }

  deleteBook(id: number){
    this.store.dispatch(new bookActions.deleteBookAction(id));
    // this.service.deleteBook(id).subscribe(data => {
    //   this.router.navigate(["/books"]);
    // })
  }

}
